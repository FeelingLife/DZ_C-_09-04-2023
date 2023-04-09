Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int n1 = Convert.ToInt32(a);
int n2 = 0;
Console.Write("Четные числа: ");
while (n2 < n1)
{
    int v = (n2 + 2);
    n2 = v;
    Console.Write(v);
};