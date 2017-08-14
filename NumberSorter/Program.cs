using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberSorter.SortPicker;

namespace NumberSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a type of sort you want to use:");
            string sortInput = Console.ReadLine();

            Console.Clear();

            foreach (var i in new Picker().SortDeterminator(sortInput, input))
                Console.Write(i + " ");
            
            Console.WriteLine();
        }
        
    }
}
