using System;
using System.ComponentModel.Design;

//Задача 1

Console.WriteLine("Введите целое число: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
   {
    Console.WriteLine("Число четное");
    Console.WriteLine();
   }
else
   {
    Console.WriteLine("Число нечетное");
    Console.WriteLine();
   }


//Задача 2

Console.WriteLine("Добро пожаловать! Сколько карт у вас на руках?");
byte a = byte.Parse(Console.ReadLine()); //поместили в переменную "а" введенное пользователем число
int summ  = 0;//установили значение суммы величин карт = 0
byte i;   //счетчик для цикла for
for (i = 0; i < a; i++)            //запустили основной цикл для ввода номинала "а"-количества карт
{
    Console.WriteLine("Введите номинал карты:"); //предлагаем пользователю ввести значение карты
    string value = Console.ReadLine();            //поместили введеннное значение в переменную value
  
    switch (value)                       //запуск проверки, не ввел ли пользователь картинку
    {
        case "j":   //прибавляем 10 к сумме карт
        case "q": 
        case "k": 
        case "t":
            summ += 10;
            break;
        default:           //в случае, если пользователь ввел цифры, мы создаем переменную типа int, 
            int cardValue; //куда сохраняем введенное пользователем значение
            if (int.TryParse(value, out cardValue)) //если введенное значение преобразуется в число, 
            {
                summ += cardValue;             //то величина прибавляется к сумме
            }
            else
            {
                Console.WriteLine("Введите корректное значение"); //если пользователь ввел другие буквы
                i--;
            }
            break;
    }
    
}
Console.WriteLine("Сумма карт у вас на руках: " + summ);  
    
    
//Задача 3. Проверка простого числа

Console.WriteLine("Введите целое число: ");
int m = int.Parse(Console.ReadLine());
bool simple = false;
i = 2;

while (i < m-1)
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

//Задача 4. Наименьший элемент в последовательности
int min = int.MaxValue;
Console.WriteLine("Введите длину последовательности");
int lenth = int.Parse(Console.ReadLine());
i = 0;

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