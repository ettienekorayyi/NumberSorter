using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter.SortPicker
{
    public class Picker
    {
        public IEnumerable<int> SortDeterminator(string sortType, string words)
        {
           if (sortType == new BubbleSort().TypeBubbleSort)
               return new BubbleSort().Sort(words.Split(',').Select(int.Parse).ToArray());
           if (sortType == new QuickSort().TypeQuickSort)
               return new QuickSort().Sort(words.Split(',').Select(n => int.Parse(n)).ToArray());

           return null;
        }

    }
}
