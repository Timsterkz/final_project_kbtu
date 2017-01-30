using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2T4
{
    class Complex // Создание нового класса Complex
    {
        int a, b;
        public Complex(int a, int b)
        {
            // Приравнивает переменным данного конструктора принимаемые значения переменных a и b
            this.a = a; 
            this.b = b;
        }
        public static Complex operator +(Complex Num1, Complex Num2) // Перегрузка оператора +
        {
            Complex result = new Complex(0, 0);
            result.a = Num1.a + Num2.a;
            result.b = Num1.b + Num2.b;
            return result;
        }
        public override string ToString() // Перезапись стандартного метода ToString()
        {
            return string.Format("The result is equal to {0} + {1}i", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex CompNum1 = new Complex(2, 4);
            Complex CompNum2 = new Complex(0, 7);
            Complex CompNum3 = CompNum1 + CompNum2; // Использует оператор + 
            Console.WriteLine(CompNum3); // Выводит результат сложения двух комплексных чисел
        }
    }
}
