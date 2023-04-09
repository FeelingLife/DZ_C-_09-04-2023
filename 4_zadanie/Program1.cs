using System;

Console.WriteLine("Никита начинает работу:");
Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
Convert.ToInt32(a);
int n1 = Convert.ToInt32(a);
Console.WriteLine("Введите второе число: ");
string b = Console.ReadLine();
Convert.ToInt32(b);
int n2 = Convert.ToInt32(b);
Console.WriteLine("Введите третье число: ");
string c = Console.ReadLine();
Convert.ToInt32(c);
int n3 = Convert.ToInt32(c);
if (n1 > n2)
{
    Console.Write(a);
    Console.WriteLine(" -max");
}
if (n1 > n3)
{
    Console.Write(a);
    Console.WriteLine(" -max");
}
if (n3 > n2)
{
    Console.Write(c);
    Console.WriteLine(" -max");
}
else
{
    Console.Write(b);
    Console.WriteLine(" -max");
};