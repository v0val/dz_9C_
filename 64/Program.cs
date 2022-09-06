void ryadChisel(int n, int m)
{
    if (m == n + 1) return;
    ryadChisel(n, m + 1);
    Console.Write($"{m} ");
}
int x = Convert.ToInt32(Console.ReadLine());
int y = 1;
ryadChisel(x, y);