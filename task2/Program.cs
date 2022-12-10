/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/


// Получает целое положительно число от пользователя
int GetNumber(string message)
{
    bool isCorrect = false;
    int number = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out number))
        {
            if (number == 0)
                Console.WriteLine("Число не должно быть равно нулю.");
            else if (number < 0)
                Console.WriteLine("Число должно быть положительным.");
            else
                isCorrect = true;
        }
            
        else
            Console.WriteLine(input.Trim() == "" ? "Вы ничего не ввели" : "Вы ввели некорректные данные");
    }
    
    return number;
}


// Вычисляет сумму цифр в числе
int DoCalculation(int number)
{
    int result = 0;

    while (number > 10)
    {
        result += number % 10;
        number /= 10;
    }
    result += number;

    return result;
}


int number = GetNumber("Введите целое положительное число: ");
int result = DoCalculation(number);

Console.WriteLine($"Сумма цифр в числе: {result}");