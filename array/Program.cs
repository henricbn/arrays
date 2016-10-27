using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] namn = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("mata in ett namn:");
                namn[i] = Console.ReadLine();
                
            }
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(namn[i]);
            }
            */
            /* övning2
            int[] tal = new int[10];
            for(int i = 0; i<10; i++)
            {
                Console.Write("Skriv ett tal:");
                tal[i] = int.Parse(Console.ReadLine());
                }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(tal[i]);
            } */
            int[] numbArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };
            int numero = 0;
            for (int i = 0; i < numbArray.Length; i++)
            {
                for(int q = i + 1; q < numbArray.Length; q++)
                {
                    if ( numbArray[i] > numbArray[q])
                    {
                        numero = numbArray[q];
                        numbArray[q] = numbArray[i];
                        numbArray[i] = numero;
                    }
                }
                Console.WriteLine(numbArray[i]);
            } 


        }
    }
}
