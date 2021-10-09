using ClassLibrary1;
using ClassLibrary1.Calculate;
using ClassLibrary1.FileManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calcultate = new Calculate();

            int a = 3;
            int b = 5;
            int sum = 0;

            sum = calcultate.Plus(a, b);
            Console.WriteLine($"sum = {sum}");

            Console.ReadLine();
            //FileManager filemanager = new FileManager();
            //filemanager.Copy("document.txt", "document_copy");


           //if (args.Length < 2)
           //{
           //    Console.WriteLine("args 갯수가 2개이어야 합니다.");
           //    return;
           //}
           //
           //
           //string srcFile = args[0];
           //string destFile = args[1];
           //
           //File.Copy(srcFile, destFile);
           //
           //Console.WriteLine($"copy {srcFile} to {destFile}");


            //Console.WriteLine("hello");
            //
            //string name = "david";
            //Console.WriteLine(name);
            //
            //Console.ReadLine();
        }
    }
}
