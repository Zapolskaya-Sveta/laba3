using System;

class Program
{
    static void Main()
    {
        int maxR = 10;
        int numCount;

        for (int i = 0; i < maxR; i++)
        {
            numCount = i / 2 + 1;

            for (int j = 0; j < numCount; j++)
            {
                if (i % 2 == 0)  
                {
                    if (j == numCount - 1)
                    {
                        Console.Write(3);
                    }
                    else
                    {
                        Console.Write(2);
                    }
                }
                else  
                {
                    if (j == numCount - 1)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(9 + j - (numCount - 2));  
                    }
                }
                if (j < numCount - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}



