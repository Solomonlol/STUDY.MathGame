using static System.Runtime.InteropServices.JavaScript.JSType;

int operation;
TimeOnly startTime =TimeOnly.FromDateTime(DateTime.Now);

;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Вопрос №{i + 1}");
    Console.WriteLine("Введите тип опрерации(1:Сложение,2:Вычитание,3:Умножение,4:Деление):");
    operation = Convert.ToInt32(Console.ReadLine());
    MathQuestion(operation);
    
}
TimeOnly endTime = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"Вы закончили за {endTime- startTime} секунд!");

void MathQuestion(int s)
{
    switch(s)
    {
        case 1:
            MathPlus();
            break;
        case 2:
            MathMinus();
            break;
        case 3:
            MathMultiply();
            break;
        case 4:
            MathDivide();
            break;
        default:
            Console.WriteLine("Неверная операция");
            break;

    }
}

void GenerateNumbers(out int firstNumber, out int secondNumber)
{
    Random firstRand = new();
    firstNumber = firstRand.Next(100);
    secondNumber = firstRand.Next(100);
}
void MathPlus()
{
    GenerateNumbers(out int first, out int second);
    Console.WriteLine($"{first}+{second}=");
    Console.WriteLine($"Введите ответ:");
    string? number = Console.ReadLine();
    if (number != null && Convert.ToInt32(number) == (first + second))
    {
        Console.WriteLine("Ответ верный!");
    }
    else Console.WriteLine($"Ответ неверный!\nПравильный ответ: {first+second}");
}
void MathMinus()
{
    GenerateNumbers(out int first, out int second);
    Console.WriteLine($"{first}-{second}=");
    Console.WriteLine($"Введите ответ:");
    string? number = Console.ReadLine();
    if (number != null && Convert.ToInt32(number) == (first - second))
    {
        Console.WriteLine("Ответ верный!");
    }
    else Console.WriteLine($"Ответ неверный!\nПравильный ответ: {first - second}");
}
void MathMultiply()
{
    GenerateNumbers(out int first, out int second);
    Console.WriteLine($"{first}*{second}=");
    Console.WriteLine($"Введите ответ:");
    string? number = Console.ReadLine();
    if (number != null && Convert.ToInt32(number) == (first * second))
    {
        Console.WriteLine("Ответ верный!");
    }
    else Console.WriteLine($"Ответ неверный!\nПравильный ответ: {first * second}");
}
void MathDivide()
{
    bool end = false;
    GenerateNumbers(out int first, out int second);
    while (!end)
    {
        if (second!=0 && first % second == 0)
        {
            Console.WriteLine($"{first}/{second}=");
            Console.WriteLine($"Введите ответ:");
            string? number = Console.ReadLine();
            if (number != null && Convert.ToInt32(number) == (first / second))
            {
                Console.WriteLine("Ответ верный!");
            }
            else Console.WriteLine($"Ответ неверный!\nПравильный ответ: {first / second}");
            end = true;
        }
        else
        {
            GenerateNumbers(out first, out second);
        }
    }
}