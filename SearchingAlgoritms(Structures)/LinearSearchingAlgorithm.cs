using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace doggy
{   
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string[] datab = new string[k];
            for (int i = 0; i < k; i++)
            {
                datab[i] = Console.ReadLine();
            }
            for(int f = 0; f<k;f++)
            {
                if (datab[f] == pattern)
                {
                    Console.WriteLine("Found!");
                    Console.WriteLine("  at the index: {0}", f);
                }
            }
            Console.ReadKey();
        }
    }
}