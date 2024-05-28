using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab0_jrao
{
    internal class Program
    {
        static void Main()
        {
            int high_num = 0;
            int low_num = 0;
            List<string> lines = new List<string>();

            while (low_num <= 0)
            {
                Console.WriteLine("Enter a low number");
                String low_input = Console.ReadLine();

                //check if input is an int
                if (CheckInt(low_input))
                {
                    low_num = Convert.ToInt32(low_input);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            
            while (high_num <= low_num)
            {
                Console.WriteLine("Enter a high number");
                String high_input = Console.ReadLine();

                //check if input is an int
                if (CheckInt(high_input))
                {
                    high_num = Convert.ToInt32(high_input);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            //calculate the difference between low and high numbers
            int diff = high_num - low_num;

            Console.WriteLine("The difference is " + diff);

            //calculate all numbers between low and high num
            int[] num_array = Enumerable.Range(low_num+1, diff-1).ToArray();

            //reverse the array
            Array.Reverse(num_array);

            //filepath of text file
            String filepath = @"C:\Users\Jazz\source\repos\Lab0_jrao\nums.txt";

            //for each number in array, add to lines list
            foreach (int num in num_array)
            {
                lines.Add(num.ToString());
            }

            //write all ints to txt file
            File.WriteAllLines(filepath, lines);
            
            //read all numbers from txt file
            String[] numbers = File.ReadAllLines(filepath);
            
            foreach(string line in numbers)
            {
                Console.WriteLine(line);
            }
            
            Console.ReadLine();
            
        }
        //method to check validity of input to see if its an int
        public static bool CheckInt(string input)
        {
            int temp;
            return int.TryParse(input, out temp);
        }
    }
}
