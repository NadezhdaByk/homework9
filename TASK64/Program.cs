// По заданным значения N и M выводит все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());
void ScrinNum (int n, int m)
{
    for (int i=n; i<= m; i++) {Console.Write($"{i} ");}
}
ScrinNum (n,m);