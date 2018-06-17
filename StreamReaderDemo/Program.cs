using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var filePath = @"c:\vidobu\cs_file.txt";

            var sr = new StreamReader(filePath);

            // Tek karakter okumak için
            //Console.WriteLine((char)sr.Read());
            //Console.WriteLine((char)sr.Read());
            //Console.WriteLine((char)sr.Read());
            //Console.WriteLine((char)sr.Read());
            //Console.WriteLine((char)sr.Read());
            //Console.WriteLine((char)sr.Read());
            //Console.WriteLine((char)sr.Read());

            //Belirli bir bloktaki karakter dizisini okumak için
            //var charArr = new char[1000];
            //sr.Read(charArr, 0, 15);

            //Console.WriteLine(charArr);

            //Tüm dosyayı okumak için
            //Console.WriteLine(sr.ReadToEnd());

            //Satır satır okumak
            //Console.WriteLine(sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());


            //Tüm dosyayı satır satır

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }


            Console.ReadKey();

        }
    }
}
