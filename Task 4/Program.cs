//Минимальное число в последовательности

int min = int.MaxValue;
Console.WriteLine("Введите длину последовательности");
int lenth = int.Parse(Console.ReadLine());
int i = 0;

do
{
    Console.WriteLine("Введите число последовательности");
    int number = int.Parse(Console.ReadLine());
    if (number < min)
    {
        min = number;
    }
    i++;
}
while (i < lenth);

Console.WriteLine("Минимальное число - " + min);
