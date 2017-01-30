using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2T2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Работа с файлами
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // Открывает файл output.txt, если
            StreamReader sr = new StreamReader(fs);                                                    // такового нет, то создает

            string line = sr.ReadToEnd(); // Считывает содержимое файла и сохраняет в массиве line
            string[] SetOfNums = line.Split(' ');

            int max = Convert.ToInt32(SetOfNums[0]);
            int min = Convert.ToInt32(SetOfNums[0]);

            Console.Write("List of numbers: ");

            for (int i = 0; i < SetOfNums.Length; i++)
            {
                Console.Write(SetOfNums[i] + " ");

                if(max < Convert.ToInt32(SetOfNums[i])) // Если i элемент массива больше чем max, то переменной max
                {                                       // присваевается значение i элемента массива
                    max = Convert.ToInt32(SetOfNums[i]);
                }
                if (min > Convert.ToInt32(SetOfNums[i])) // Если i элемент массива меньше чем min, то переменной min
                {                                        // присваевается значение i элемента массива
                    min = Convert.ToInt32(SetOfNums[i]);
                }
            }

            Console.WriteLine(); // Текст ниже будет выведен с новой строки
            Console.WriteLine("Maximum number is " + max);
            Console.WriteLine("Minimum number is " + min);

            sr.Close();
            fs.Close();
        }
    }
}
