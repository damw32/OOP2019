using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 10;
           
            int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            for (i = 1; i <= 10; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\n");
            
            for (i = 1; i <= tab.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            for(i=n-1;i>=0;i--)
            {
                Console.WriteLine(tab[i]);
            }
           
            Console.ReadKey();
        }

        

    }
}
