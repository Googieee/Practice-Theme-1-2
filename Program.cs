using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Theme_1__2
{
    internal class Program
    {

    }

public class MathOperations
    {
        private int Cube(int number)
        {
            return number * number * number;
        }
        private int Summa(int number1, int number2) 
        { 
            return (number1 + number2);
        }
        public void Demonstrate()
        {
            Console.Write("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            int plusik = Summa(a,b);
            Console.WriteLine("Сумма: " + plusik);
            Console.Write("Введите число, которое нужно возвести в куб:");
            int c = Convert.ToInt32(Console.ReadLine());
            int cubedValue = Cube(c);
            Console.WriteLine("Куб: " + cubedValue);
        }

        public static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            operations.Demonstrate();
        }
    }
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age  { get; set; }
        public int ZarPlata { get; set; }
    }
}

