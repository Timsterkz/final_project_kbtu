using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 3;
            for(int i = 0; i < args.Length; i++) // Цикл работает пока значение i меньше длины массива args
            {
                if(Convert.ToInt32(args[i])%2 != 0) // Элементы массива args имеют тип данных string, поэтому они были конвертированы в int32
                {                                   // Если число является четным, то оно не может быть простым. То есть, остаток от деления на
                    while (true)                    // 2 не должен быть равен 0.
                    {
                        if (Convert.ToInt32(args[i]) == 1) // Число 1 не является ни простым ни четным числом.
                        {                                  // Поэтому было добавлено дополнительное условие выхода из цикла
                            break;
                        }
                        if (j == Convert.ToInt32(args[i])) 
                        {
                            Console.Write(j + " ");
                            break;
                        }
                        if (Convert.ToInt32(args[i])%j == 0) // Если число делится на j без остатка, то оно не является простым
                        {                                    // Следовательно, можно выйти из цикла
                            break;
                        }
                        j += 2;
                    }
                }
                j = 3;
            }
        }
    }
}
