using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    public class QuickSort : AbstractSorter
    {
        private const string sortType = "Quick Sort";

        public String TypeQuickSort
        {
            get
            {
                return sortType;
            }
        }
        public override IList<int> Sort(int[] items)
        {
            return Sort(items, 0, items.Length - 1).ToList<int>();
        }

        private static int[] Sort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                    i++;

                while (elements[j].CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                    Swap(elements, i, j);
                    i++;
                    j--;
            }
            return elements;
        }


        private static int[] Swap(int[] items, int left, int right)
        {
            int tmp = items[left];
            items[left] = items[right];
            items[right] = tmp;

            return items;
        }

    }
}
