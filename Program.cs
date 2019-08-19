using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
            string[] words = { "eli", "perviz","eli","mahmud","mahmud","ilkin" };

            foreach (var item in Countwords(words))
            {
                Console.WriteLine(item);
               
            }
            Console.ReadKey();
		}
        static string[] Countwords (string[] word)
        {
            string[] empty = new string[100];
            int empcount=0;
            int[] numbers = new int[100];
            int numcount = 0;
            int count = 0;
            string[] result = new string[10];
            int rescount = 0;
            
            foreach (var item in word)
            {
                count = 0;
                foreach (var second in word)
                {
                   
                    if (item == second )
                        count++; 
                }
                foreach (var third in word)
                {
                    if (Array.IndexOf(empty, item) == -1)
                    {
                        empty[empcount] = item;
                        empcount++;
                        numbers[numcount] = count;
                        numcount++;
                    }
                }
            }
            Array.Resize(ref empty, empcount);
            Array.Resize(ref numbers, numcount);
            for (int i = 0; i < empty.Length; i++)
            {
                result[rescount] = $"{empty[i]} - {numbers[i]}";
                rescount++;
            }

            return result;
        } 
	}
}
