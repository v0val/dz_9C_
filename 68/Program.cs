Console.Write("Введи целые неотрицательные числа х и у (х<y) ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else 
    {
         if (m != 0 && n == 0) return AkkermanFunc(m - 1, 1);
         else 
         {
            return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1 ));
         }
    }
        
}
Console.Write(AkkermanFunc(x, y));