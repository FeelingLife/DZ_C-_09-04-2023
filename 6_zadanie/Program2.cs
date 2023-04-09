Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
double n1 = Convert.ToDouble(a);
if ((n1 % 2) == 0)
{
    Console.Write(n1);
    Console.WriteLine(" - Число четное");
}
else
{
    Console.Write(n1);
    Console.WriteLine(" - Число нечетное");
};