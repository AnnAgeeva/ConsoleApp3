//Проверка простого числа

Console.WriteLine("Введите целое число: ");
int m = int.Parse(Console.ReadLine());
bool simple = false;
int i = 2;

while (i < m - 1)
{

    if (m % i == 0)
    {
        simple = true;
        Console.WriteLine("Число составное"); //при вводе составного числа у меня выводится столбец с этой фразой. Не знаю, как исправить
    }
    else
    {
        i++;
    }
}
Console.WriteLine(m + " - простое число");
