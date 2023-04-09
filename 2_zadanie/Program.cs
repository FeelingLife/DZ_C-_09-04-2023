using System;

Console.WriteLine("Никита начинает работу:");
Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
Convert.ToInt32(a);
int n1 = Convert.ToInt32(a);
Console.WriteLine("Введите число: ");
string b = Console.ReadLine();
Convert.ToInt32(b);
int n2 = Convert.ToInt32(b);
if (n1 > n2)
{
    Console.Write(a);
    Console.WriteLine(" -max");
    Console.Write(b);
    Console.WriteLine(" -min");
}
else
{
    Console.Write(b);
    Console.WriteLine(" -max");
    Console.Write(a);
    Console.WriteLine(" -min");
};