// Вычисляет функцию Аккермана с помощью рекурсии по введенным двум неотрицательным числам m и n.
Console.WriteLine("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m==0) return n+1;
    else if (m!=0 && n==0) return Akkerman (m-1, 1);
    else return Akkerman(m-1, Akkerman(m,n-1));
}
Console.WriteLine(Akkerman(m,n));