using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizBaklavaDilimi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("boyut giriniz");
            int boyut = int.Parse(Console.ReadLine());

            for (int i = 1; i <= boyut; i++)
            {
                for (int k = boyut; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            for (int i = boyut - 1; i > 0; i--)
            {
                for (int k = boyut; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
