using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sorting
{
    public class OneClassToRuleThemAll
    {
        private readonly ISort _sortAlgorithm;

        public OneClassToRuleThemAll(ISort sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        public List<int> PerformSort(List<int> list, bool ascending)
        {
            return _sortAlgorithm.Sort(list, ascending);
        }
    }
}
