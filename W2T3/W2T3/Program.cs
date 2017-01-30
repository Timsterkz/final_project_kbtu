using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2T3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Работа с файлами
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // Открывает файл output.txt. Если такового не существует, создает.
            StreamReader sr = new StreamReader(fs); 

            string line = sr.ReadToEnd(); // Полностью считывает содержимое файла и сохраняет в массиве line
            string[] SetOfNums = line.Split(' '); 

            int i = 0;
            int j = 3;
            int min = 0;
            bool b = true;

            while (true)
            {
                if(i == SetOfNums.Length) // Закрытие цикла
                {
                    break;
                }
                if(Convert.ToInt32(SetOfNums[i]) % 2 != 0) // Если число четное, то оно не может быть простым
                {
                    while (b)
                    {
                        if(j == Convert.ToInt32(SetOfNums[i])) // Закрытие вложенного цикла
                        {
                            if(min==0) 
                            {
                                min = j;
                            }
                            else
                            {
                                if(min>j)
                                {
                                    min = j;
                                }
                            }
                            b = false;
                        }
                        if (Convert.ToInt32(SetOfNums[i]) % j == 0) // Если чисто делится на j без остатка, то оно не может быть простым
                        {
                            b = false;
                        }
                        j += 2;
                    }
                }

                b = true;
                j = 3;
                i++;
            }

            Console.WriteLine(min);

            // Закрытие stream-ов
            sr.Close();
            fs.Close();
        }
    }
}
