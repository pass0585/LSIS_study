using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class buttonBinary2 : Form
    {
        public buttonBinary2()
        {
            InitializeComponent();
        }


        private void buttonTextFile_Click(object sender, EventArgs e)
        {
            //File
            //File.WriteAllText("text,txt", "Data 1");
            //File.AppendAllText("text,txt", "Data 2");
            //File.AppendAllText("text,txt", "Data 3");

            string data = "Data 1\r\nData 2\r\nData 3";
            File.WriteAllText("text.txt", data);

            string readData = File.ReadAllText("text.txt");
            MessageBox.Show(readData);

            //간단한 데이터를 한번에 읽고 쓸때 사용
        }

        private void buttonTextFile2_Click(object sender, EventArgs e)
        {
            // 연속적인 데이터를 처리, 양이 많을 경우
            StreamWriter wr = new StreamWriter("streamData.txt");

            for (int i = 0; i < 1000; i++)
            {
                wr.WriteLine($"Data {i}");      
                // 파일을 한번만 열고 1000번 쓰고, 닫는다 빠름!
                
                //File.AppendAllText("text2.txt", $"Data {i}") 
                // 루프를 돌때마다 파일을 오픈하고 데이터를 쓰고, 파일을 닫는 행위를 반복한다. 느림
            }

            wr.Close();

            #region // 첫번째 방법

            /*StreamReader rd = new StreamReader("streamData.txt");
            
            for (int i = 0; i < 100; i++)
            {
                string s = rd.ReadLine();
            
                if(s != null)
                {
                    Debug.WriteLine(s);
            
                }
            }
            
            rd.Close();*/
            #endregion
            #region// 두번쨰 방법 try ~ finally

            /*StreamReader rd = null;

            try
            {
                rd = new StreamReader("streamData.txt");

                for (int i = 0; i < 100; i++)
                {
                    string s = rd.ReadLine();

                    if (s != null)
                    {
                        Debug.WriteLine(s);

                    }
                }
            }
            finally
            {

                if (rd != null)
                {
                    rd.Dispose();
                    rd.Close();
                }
            }*/
            #endregion
            // 세번째 방법 using
            using (StreamReader rd = new StreamReader("streamData.txt"))
            {
                for (int i = 0; i < 100; i++)
                {
                    string s = rd.ReadLine();

                    if (s != null)
                    {
                        Debug.WriteLine(s);

                    }
                }

            }
        }

        private void buttonBinary1_Click(object sender, EventArgs e)
        {
            byte[] bytes = File.ReadAllBytes(@"C:\Users\pass0\Desktop\image.png");
            int size = bytes.Length;

            Debug.WriteLine(size);

            File.WriteAllBytes(@"C:\Users\pass0\Desktop\target.png", bytes);
            // 파일이 큰 경우 좋은 방식은 아님
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"C:\Users\pass0\Desktop\image.png", FileMode.Open))
            {
                int size = (int)fs.Length;
                byte[] buff = new byte[size];

                // 이미지를 10번에 걸쳐서 나눠서 읽음
                for (int i = 0; i < 10; i++)
                {
                    int n = fs.Read(buff, 0, size / 10);

                    Debug.WriteLine(n);
                }
            }
        }

        private void buttonBinary3_Click(object sender, EventArgs e)
        {
            // binary 파일 쓰기
            FileStream fs1 = File.Open("test.bin", FileMode.Create);

            using (BinaryWriter wr = new BinaryWriter(fs1))
            {
                wr.Write(123);
                wr.Write(new byte[] { 0xff, 0x00, 0xcc });
                wr.Write("hello");
            }

            // binary 파일 읽기
            FileStream fs2 = File.Open("test.bin", FileMode.Open);

            using(BinaryReader rdr = new BinaryReader(fs2))
            {
                int i = rdr.ReadInt32();
                byte[] bytes = rdr.ReadBytes(3);
                string s = rdr.ReadString();

                MessageBox.Show(($"{i} {bytes[0].ToString("X")} {s}"));

            }
        }
    }
}
