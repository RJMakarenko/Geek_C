﻿Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
    if (i % 2 ==0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    i++;
}
