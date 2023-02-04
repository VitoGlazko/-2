//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("введите трёх значное число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Вторая цифра равна {(n/10)%10}");

Console.Write("для просмотра следующей задачи введите 1: ");
int y = int.Parse(Console.ReadLine()!);
if (y==1)
{
    Console.Clear();
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("введите число: ");
int w = int.Parse(Console.ReadLine()!);

if (w/100==0)
{
    Console.WriteLine("нету третьей цифры");
}
while (w>1000)
{
    w = w /10;
    if (w<1000)
    {
        w=w%10;
        Console.WriteLine($"третья цифра вашего числа равна {w}");
        break;
    }
}

Console.Write("для просмотра следующей задачи введите 1: ");
int u = int.Parse(Console.ReadLine()!);
if (u==1)
{
    Console.Clear();
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("введите цифру дня недели: ");
int b = int.Parse(Console.ReadLine()!);

if (b<=5)
{
    Console.WriteLine("Это будний день");
}
else if (b>5 && b<8)
{
    Console.WriteLine("Это Выходной день");
}
else 
{
    Console.WriteLine("Я не знаю такой день недели");
}
