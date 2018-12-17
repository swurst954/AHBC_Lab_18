using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC_Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(16);
            list.AddLast(27);
            list.AddLast(8);
            list.AddLast(1);
            list.AddLast(4);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }
            Console.WriteLine("---------------------");

            bool indexBool = list.RemoveAt(8);

            Console.WriteLine(indexBool);
            Console.WriteLine("---------------------");

            list.PrintReverse();


            //2
            int[] numArray = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            Console.WriteLine("---------------------");

            Frequency(numArray);
            Console.WriteLine("---------------------");
            DictionaryFreq(numArray);

            Console.ReadKey();
        }

		// James -- I would put this in a sepreate class and file honestly. 
        public static void Frequency(int[] numberArray)
        {
            int arrayCount = numberArray.Max();

            int[] arrayFreq = new int[arrayCount + 1];

            for (int i = 0; i < arrayFreq.Length; i++)
            {
                for (int j = 0; j < numberArray.Length; j++)
                {
                    if (numberArray[j] == i)
                    {
                        arrayFreq[i]++;
                    }
                }
            }
            for (int i = 0; i < arrayFreq.Length; i++)
            {
                if (arrayFreq[i] > 0)
                {
                    Console.WriteLine($"[{i}]: {arrayFreq[i]}");
                }
            }
        }

		// James -- Same as the last method, different file and different class.
        public static void DictionaryFreq(int[] numberArray)
        {
            Dictionary<int, int> list = new Dictionary<int, int>();

            foreach (int number in numberArray)
            {
                if (list.ContainsKey(number))
                {
                    list[number]++;
                }
                else
                {
                    list.Add(number, 1);
                }
            }
            foreach (var item in list.OrderBy(key => key.Key))
            {
                Console.WriteLine($"[{item.Key}]: {item.Value}");
            }
        }
    }
}
