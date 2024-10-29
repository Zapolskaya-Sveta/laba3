using System;
class Program
{
    static void Main()
    {
        int num = 100;
        while (num <= 999)
        {
            int n1 = num / 100;
            int n2 = num % 10;

            if (n1 == n2)
            {
                Console.WriteLine(num);
            }

            num++;
        }
    }
}