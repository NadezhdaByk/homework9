// По заданным значения N и M выводит сумму всех натуральные числа в промежутке от M до N.
Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());
int ScrinNumRecurs (int n, int m)
{
    if (m>=n) return m + ScrinNumRecurs (n, m-1);
    else return 0;
}
Console.Write($"Сумма натуральных чисел от {n} до {m} равна {ScrinNumRecurs(n,m)}");
//метод без рекурсии
// int ScrinNum (int n, int m)
// {
//     int sum = n;
//     for (int i=n+1; i<= m; i++) {sum+=i;}
//     return sum;
// }
// Console.Write($"Сумма натуральных чисел от {n} до {m} равна {ScrinNum (n,m)}");