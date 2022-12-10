/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

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


// Возводит number1 в степень number2
int DoCalculation(int number1, int number2)
{
    int result = 1;

    for (int i = 1; i <= number2; i ++)
        result *= number1;

    return result;
}


int number1 = GetNumber("Введите целое положительное число: ");
int number2 = GetNumber("Введите ещё одно целое положительное число: ");
int result  = DoCalculation(number1, number2);

Console.WriteLine($"Первое число в степени второго числа: {result}");