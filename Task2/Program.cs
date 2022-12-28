using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Source;
using Task2.Source.Events;

namespace Task2
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int[] source = { 10, 20, 30, 40, 50 };
            var obj = new DynamicArray<int>(source);

            Console.WriteLine(obj.Contains(10));

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }

        public static void CapacityChanged(object sender, CapacityEventArgs e)
        {
            Console.WriteLine($"{e.GetType()} : {e.OldCapacity} -> {e.NewCapacity}");
        }
    }
}
