using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
           
                int num = 4;

                Console.WriteLine("The sequence of moves involved in the Tower of Hanoi are:\n");

                towerOfHanoi(num, 'A', 'C', 'B');

                Console.ReadLine();

         }

        public static void towerOfHanoi(int num, char src, char dst, char temp)

        {
            if(num == 1)
            {
                Console.WriteLine($"Move disk 1 from {src} to {dst}");
                return;
            }

            towerOfHanoi(num - 1, src, dst, temp);
            Console.WriteLine($"Move disk {num} from {src} to {dst}");
            towerOfHanoi(num - 1, temp, src, dst);
            

        }

        public static int GCD(int m, int  n) 
        {
            if(n == 0)
            {
                return m;
            }
            else
            {
                return (GCD(n, m % n));
            }
            
        }

        public static int fibonnaci(int n)
        {
            if(n <= 1)
            {
                return n;
            }
            else
            {
               return fibonnaci(n - 1) + fibonnaci(n - 2);
            }
            
        }

        
    }
    
}
