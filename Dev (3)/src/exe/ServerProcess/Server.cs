using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ServerProcess
{
    public class Server
    {
        private static OdbcConnection myConnection = new OdbcConnection();
        public bool IsConnected
        {
            get { return myConnection.State == ConnectionState.Open; }
        }
        private Thread ReadDataThread
        {
            get; set;
        }
        private Thread WriteDataThread
        {
            get; set;
        }
        private CancellationTokenSource ThreadCancelToken
        {
            get; set;
        }
        private Dictionary<int, Record> record = new Dictionary<int, Record>();
        public void Start()
        {
            if ((this.ReadDataThread == null || !this.ReadDataThread.IsAlive) &&
                (this.WriteDataThread == null || !this.WriteDataThread.IsAlive))
            {
                // 스레드 시작
                this.ThreadCancelToken = new CancellationTokenSource();
                this.ReadDataThread = new Thread(this.ReadData)
                {
                    Name = nameof(this.ReadData),
                    IsBackground = true
                };
                this.WriteDataThread = new Thread(this.WriteData)
                {
                    Name = nameof(this.WriteData),
                    IsBackground = true
                };
                this.ReadDataThread.Start();
                this.WriteDataThread.Start();
            }
        }
        private void ReadData()
        {
            CancellationToken token = this.ThreadCancelToken.Token;
            while (!token.IsCancellationRequested)
            {
                this.SelectRecord();//
                Console.WriteLine("Read Data");
                Thread.Sleep(1000);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void SelectRecord()
        {
            CancellationToken token = this.ThreadCancelToken.Token;
            while (!token.IsCancellationRequested)
            {
                string selectQuery = @"select * from writetable where flag = 0 limit 5";
                this.GetRecord(selectQuery);
                if (this.record.Count > 0)
                {
                    foreach (var rec in this.record)
                    {
                        bool ret = this.Processing(rec.Value);
                        // 
                        if (ret)
                        {
                            this.UpdateRecord(rec.Value);
                            //Console.WriteLine("{0} Record 처리완료", rec.Key);
                        }
                        Thread.Sleep(1000);
                    }
                }
                Thread.Sleep(5000);
            }
        }
        private void GetRecord(string query)
        {
            this.record.Clear();
            // Transaction start
            OdbcTransaction transaction = myConnection.BeginTransaction();
            using (OdbcCommand cmd = myConnection.CreateCommand())
            {
                cmd.Connection = myConnection;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.Text;
                try
                {
                    // select inserted id
                    cmd.CommandText = query;
                    var rec = cmd.ExecuteReader();
                    while (rec.Read())
                    {
                        this.AddRecord(rec);
                    }
                    rec.Close();
                }
                catch (Exception e)
                {
                    // 쿼리 수행 중 예외 발생 시 Rollback 처리를 합니다.
                    transaction.Rollback();
                    throw new Exception(e.ToString());
                }
            }
            // Transaction commit
            transaction.Commit();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rec"></param>
        private void AddRecord(OdbcDataReader rec)
        {
            int key = (int)rec["id"];
            if (!this.record.ContainsKey(key))
            {
                Record record = new Record();
                record.ID = key;
                record.Value = (int)rec["value"];
                record.Flag = (bool)rec["flag"];
                this.record.Add(key, record);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        private bool Processing(Record rec)
        {
            rec.Value = rec.Value * 2;
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rec"></param>
        private void UpdateRecord(Record rec)
        {
            string Update = @"UPDATE writetable SET flag=1, value='{0}', time='{1}', evaluation='{2}' WHERE Id='{3}'";
            string evaluation = string.Empty;
            if (rec.Value <= 6)
            {
                evaluation = "FAIL";
            }
            else if (rec.Value > 7 && rec.Value <= 14)
            {
                evaluation = "PASS";
            }
            else
            {
                evaluation = "GREAT";
            }
            string query = string.Format(Update, rec.Value, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), evaluation, rec.ID);
            OdbcTransaction transaction = myConnection.BeginTransaction();
            using (OdbcCommand cmd = myConnection.CreateCommand())
            {
                cmd.Connection = myConnection;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    // 쿼리 수행 중 예외 발생 시 Rollback 처리를 합니다.
                    transaction.Rollback();
                    throw new Exception(e.ToString());
                }
            }
            // Transaction commit
            transaction.Commit();
        }
        private void WriteData()
        {
            CancellationToken token = this.ThreadCancelToken.Token;
            while (!token.IsCancellationRequested)
            {
                Random random = new Random();
                int value = random.Next(10);
                this.InsertRecord(value);
                Console.WriteLine($"Write Data : {value}");
                Thread.Sleep(1000);
            }
        }
        private void InsertRecord(int value)
        {
            string insert = @"INSERT INTO writetable(flag, Value) VALUES (0, '{0}')";
            string query = string.Format(insert, value);
            OdbcTransaction transaction = myConnection.BeginTransaction();
            using (OdbcCommand cmd = myConnection.CreateCommand())
            {
                cmd.Connection = myConnection;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw new Exception(e.ToString());
                }
            }
            transaction.Commit();
        }
        public void Connect()
        {
            string connBaseString = @"DRIVER={0};SERVER={1};PORT={2};DATABASE={3};UID={4};PWD={5}";
            string conString = string.Empty;
            conString = string.Format(
                    connBaseString,
                    "MariaDB ODBC 2.0 Driver",
                    "127.0.0.1",
                    "3306",
                    "test",
                    "root",
                    "7");
            try
            {
                myConnection.ConnectionString = conString;
                myConnection.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void Stop()
        {
            // 스레드 종료
            if (this.ReadDataThread != null && this.WriteDataThread != null)
            {
                this.ThreadCancelToken.Cancel();
                this.ReadDataThread.Join();
                this.WriteDataThread.Join();
                this.ThreadCancelToken.Dispose();
                this.ThreadCancelToken = null;
                this.ReadDataThread = null;
                this.WriteDataThread = null;
            }
        }
    }
}
