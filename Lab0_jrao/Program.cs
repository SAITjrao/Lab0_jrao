using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0_jrao
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a low number");
            int low_num = Convert.ToInt32(Console.ReadLine());
            while (low_num <= 0)
            {
                Console.WriteLine("Enter a low number");
                low_num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter a high number");
            int high_num = Convert.ToInt32(Console.ReadLine());

            while (high_num <= low_num)
            {
                Console.WriteLine("Enter a high number");
                high_num = Convert.ToInt32(Console.ReadLine());
            }

            int diff = high_num - low_num;
            Console.WriteLine("The difference is " + diff);
            Console.ReadLine();
        }
    }
}
