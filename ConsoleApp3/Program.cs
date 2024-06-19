using System;

class Program
{
    static void Main()
    {
        decimal number1, number2;

        while (true)
        {
            Console.WriteLine("Введите первое число:");
            number1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            number2 = Convert.ToDecimal(Console.ReadLine());

            if ((number1 >= 0 && number1 <= 10) && (number2 >= 0 && number2 <= 10))
            {
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа должны быть в диапазоне от 0 до 10. Попробуйте снова.");
            }
        }

        decimal result = number1 * number2;
        Console.WriteLine($"Произведение чисел {number1} и {number2} равно: {result}");
    }
}
