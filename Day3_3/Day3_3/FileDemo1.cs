using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day3_3
{
    internal class FileDemo1
    {
        FileStream fs;
        public void WriteToFile()
        {
            fs = new FileStream("TestFile1.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            string str;
            Console.WriteLine("enter a sentence");
            str = Console.ReadLine();
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(str);
            sw.Flush();
            Console.WriteLine("Data saved to file");
            fs.Close();

        }
        public void ReadFromFile()
        {
            fs = new FileStream("TestFile1.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string data = sr.ReadToEnd();
            Console.WriteLine($"{data}");

        }
    }
}
