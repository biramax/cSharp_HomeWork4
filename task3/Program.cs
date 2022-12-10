/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/


// Получает целое положительно число от пользователя
int GetNumber(string message, bool notNull = true, bool notNegative = true, bool lowestValueExists = false, int lowestValue = 0)
{
    bool isCorrect = false;
    int number = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out number))
        {
            if (notNull && number == 0)
                Console.WriteLine("Число не должно быть равно нулю.");
            
            else if (notNegative && number < 0)
                Console.WriteLine("Число должно быть положительным.");
            
            else if (lowestValueExists && number <= lowestValue)
                Console.WriteLine($"Число должно быть больше {lowestValue}.");
            
            else
                isCorrect = true;
        }
            
        else
            Console.WriteLine(input.Trim() == "" ? "Вы ничего не ввели" : "Вы ввели некорректные данные");
    }
    
    return number;
}


// Формирует массив с рандомными значениями
int[] GetRandomArray(int arrayLength, int arrayLowestValue, int arrayHighestValue)
{
    int[] array = new int[arrayLength];
    Random rnd = new Random();

    for (int i = 0; i < arrayLength; i ++)
        array[i] = rnd.Next(arrayLowestValue, arrayHighestValue + 1);
    
    return array;
}


int arrayLength       = GetNumber("Введите размер массива: ");
int arrayLowestValue  = GetNumber("Введите нижнюю границу значений массива: ", false, false);
int arrayHighestValue = GetNumber("Введите верхнюю границу значений массива: ", false, false, true, arrayLowestValue);
int[] array           = GetRandomArray(arrayLength, arrayLowestValue, arrayHighestValue);


// Выводим массив в консоль
Console.Write("[");
for (int i = 0; i < arrayLength; i ++)
    Console.Write(array[i]+(i < arrayLength - 1 ? ", " : ""));
Console.Write("]");
