using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class ProductionCapacityComparer: IComparer<Production>
    {
        public int Compare(Production? x, Production? y)
        {
            return x!.Capacity.CompareTo(y!.Capacity);
        }
    }
}
