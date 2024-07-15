using System;
using System.ComponentModel.Design;

//Задача 5. Угадай число
Console.WriteLine("Введите максимальное число диапазона");
int range = int.Parse(Console.ReadLine());
Random rand  = new Random();

int randomintresult  = rand.Next(0,range);

do
{
    Console.WriteLine("Введите число");
    string num = Console.ReadLine();
    
   if (num ==string.Empty)
    {
        Console.WriteLine("Было загадано число " + randomintresult);
        break;
    }

    int usernumber;
    usernumber = int.Parse(num);

    if (usernumber == randomintresult)
    {
        Console.WriteLine("Верно!");
        break;
    }
   
    else
    {
        if (usernumber > randomintresult)
        {
            Console.WriteLine("Увы, вы ошиблись. Загаданное число меньше. Попробуйте еще раз. Чтобы выйти, нажмите Enter");
        }
        else
        {
            Console.WriteLine("Увы, вы ошиблись. Загаданное число больше. Попробуйте еще раз. Чтобы выйти, нажмите Enter");
        }
    }
    
}
while (1==1);