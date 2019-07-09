using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;
using Easy.Common.Extensions;
namespace TestEasyCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            var fn = ".\\Intel.txt";
            var fs = new FileStream(fn, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (StreamReader sr = new StreamReader(fs))
            {
                int i = 0;
                while(sr.ReadLine() != null)                {
                    i++;
                }
                var lines = fs.CountLines();
                if (lines != i)
                    throw new Exception("Easy not working");
            }
        }
    }
}
