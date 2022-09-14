using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод первого числа
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //ввод второго числа
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //ввод операции
            Console.WriteLine("Enter operation(+, -, *, /): ");

            string conv = Console.ReadLine();
            //Console.WriteLine(conv);

            //выполнение операций
            if(conv.Equals("+"))
            {
                Console.Write(num1 + num2);
            }
            else if(conv.Equals("-"))
            {
                Console.Write(num1 - num2);
            }
            else if (conv.Equals("*"))
            {
                Console.Write(num1 * num2);
            }
            else if (conv.Equals("/"))
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.Write("Invalid operation");
            }

        }
    }
}
