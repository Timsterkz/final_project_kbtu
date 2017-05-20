using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo File = new DirectoryInfo(@"C:\final\Final1Con\Final1Con\bin\Debug");
            for (int i = 0; i < File.GetFileSystemInfos().Length; i++)
            {
                if (File.GetFileSystemInfos()[i].Name.Contains(".txt"))
                {
                    Console.WriteLine(File.GetFileSystemInfos()[i].Name);
                    string T = File.GetFileSystemInfos()[i].Name;
                    StreamReader Sr = new StreamReader(T);
                    string p = Sr.ReadLine();
                    string[] g = p.Split();
                    int[] a = new int[g.Length];
                    for (int j = 0; j < g.Length; j++)
                    {
                        a[j] = int.Parse(g[j]);
                        if (a[j] % 2 == 0)
                        {
                            Console.WriteLine(" " + a[j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
