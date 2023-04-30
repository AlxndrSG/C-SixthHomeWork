// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int length = Prompt("Введите колличество чисел: ", "Ошибка ввода!");
int min = Prompt("Начальное значение: ", "Ошибка ввода!");
int max = Prompt("Конечное значение: ", "Ошибка ввода!");

int[] array = GenerateArray(length, min, max);
int posNumber = FindPositineNumber(array);
PrintArrayWithAmountNumber(array);

int Prompt(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArrayWithAmountNumber(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine($" -> {posNumber}");
}

int FindPositineNumber(int[] arr)
{
    int pos=0;
    foreach (int el in arr)
    {
        if (el > 0)
        pos++;
    }
    return pos;
}

