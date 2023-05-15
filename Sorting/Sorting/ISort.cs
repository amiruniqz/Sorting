using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sorting
{
    public interface ISort
    {
            List<int> Sort(List<int> arr, bool ascending = true);
    }
}
