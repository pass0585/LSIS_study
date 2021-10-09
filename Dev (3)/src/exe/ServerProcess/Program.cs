using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerProcess
{
    class Program
    {
        private static ManualResetEvent QuitEvent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            Console.CancelKeyPress += Console_CancelKeyPress;

            //Thread th = new Thread(thread);
            //th.Start();

            Server server = new Server();

            server.Connect();
            server.Start();

            Console.WriteLine("Server start");
            QuitEvent.WaitOne();

            server.Stop();
            Console.WriteLine("Server stop");
        }

        private static void thread() 
        {
            Console.WriteLine("Server Start");

            while (!QuitEvent.WaitOne(0))
            {
                Console.WriteLine("Task 1");
                Thread.Sleep(1000);

                Console.WriteLine("Task 2");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Finish");
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            QuitEvent.Set();
            e.Cancel = true;
            //Console.WriteLine("종료 명령");
        }
    }
}
