using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSorter
{
    public abstract class AbstractSorter
    {
        public abstract IList<int> Sort(int[] items);
    }
}
