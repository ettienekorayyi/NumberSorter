using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    public class BubbleSort : AbstractSorter
    {
        private const string sortType = "Bubble Sort";

        public String TypeBubbleSort
        {
            get 
            {
                return sortType;
            }
        }
        public override IList<int> Sort(int[] items)
        {
            int lastUnsorted = items.Count() - 1;
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                for (int ctr = 0; ctr < lastUnsorted; ctr++)
                {
                    if (items[ctr] > items[ctr + 1])
                        Swap(items, ctr, ctr + 1);
                        isSorted = false;
                }
                lastUnsorted--;
            }
            return items.ToList<int>();
        }

        private static int[] Swap(int[] items, int i, int j)
        {
            int tmp = items[i];
            items[i] = items[j];
            items[j] = tmp;

            return items;
        }
    }
}
