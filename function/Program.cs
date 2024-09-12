using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace function
{
    internal class Program
    { 
        static List<int> EnterIntegerValue(int count)
        {
            List<int> list = new List<int>();
            for(int i = 0;i<count; i++)
            {
                int value = 0;
                Console.Write("Enter value: ");
                value=int.Parse(Console.ReadLine());
                Console.WriteLine($"value: {value}");
                list.Add(value);
            }
            return list;
        }

        static void DisplayList(List<int> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($" {list[i]} ");
            }
            Console.WriteLine("]");
        }

        static double GetAverage(List<int> list)
        {
            int sum = 0;
            int counter = 0;
            for(int i =0; i<list.Count; i++)
            {
                sum=sum+list[i];
                counter++;
            }
            double average = sum / counter;
            return average;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a value to loop: ");
            int count = int.Parse(Console.ReadLine());
            List<int>list= EnterIntegerValue(count);
            DisplayList(list);
            double x =GetAverage(list);
            Console.WriteLine($"Average is : {x}");
        }
    }
}
