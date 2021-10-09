using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.FileManager
{
    public class FileManager
    {
        public void Copy(string src, string dest)
        {
            File.Copy(src, dest);

            Console.WriteLine("파일을 복사했습니다.");

        }
    }
}
