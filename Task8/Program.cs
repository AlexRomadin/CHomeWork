﻿int n, current;

Console.Write("Imput number");
n = Convert.ToInt32(Console.ReadLine());

current = n * (-1);

while(current <=n);
{
    Console.Write(current + " ");
    current++;
}
