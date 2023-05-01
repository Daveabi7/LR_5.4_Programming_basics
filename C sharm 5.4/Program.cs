using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        for (int i = 1; i <= 99; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}


