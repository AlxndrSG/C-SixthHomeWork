// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

int b1 = Prompt("Введите число b1: ", "Ошибка ввода!");
int k1 = Prompt("Введите число k1: ", "Ошибка ввода!");
int b2 = Prompt("Введите число b2: ", "Ошибка ввода!");
int k2 = Prompt("Введите число k2: ", "Ошибка ввода!");

double findX = FindPositionX(b1, k1, b2, k2);
double findY = FindPositionY(b1, k1, b2, k2);

PrintArrayWithAmountNumber(findX, findY);

void PrintArrayWithAmountNumber(double findX, double findY)
{
    Console.Write($"b1={b1},k1={k1},b2={b2},k2={k2} -> ({findX};{findY})");
}

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

double FindPositionX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindPositionY(double b1, double k1, double b2, double k2)
{
    double y = k1 * FindPositionX(b1, k1, b2, k2) + b1;
    return y;
}

