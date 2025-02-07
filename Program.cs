using System;

namespace App
{
    class App
    {


        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Number 1: ");
            int number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int number2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Option: (+ - * /)");
            String? option = Console.ReadLine();

            switch(option)
            {
                case "+":
                    Console.WriteLine($"{number1} + {number2} = " +
                        $"{number1 + number2}");
                    Console.ReadLine();
                    break;

                case "-":
                    Console.WriteLine($"{number1} - {number2} = " +
                        $"{number1 - number2}");
                    Console.ReadLine();
                    break;

                case "*":
                    Console.WriteLine($"{number1} * {number2} = " +
                        $"{number1 * number2}");
                    Console.ReadLine();
                    break;


                case "/":
                    Console.WriteLine($"{number1} / {number2} = " +
                        $"{number1 / number2}");
                    Console.ReadLine();
                    break;

            }


        }

        
    }
}
