int summ = 0;
int sumChisel(int m, int n)
{
    if (m == n + 1) return summ;
    summ += m;
    sumChisel(m + 1, n);
    return summ;
}
Console.Write("Введи целые числа х и у (х<y) ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.Write(sumChisel(x, y));