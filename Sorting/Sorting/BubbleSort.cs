using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sorting
{
    public class BubbleSort : ISort
    {
        public List<int> Sort(List<int> list, bool ascending = true)
        {
            List<int> sortedList = new List<int>(list);

            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                for (int j = 0; j < sortedList.Count - i - 1; j++)
                {
                    if (ascending)
                    {
                        if (sortedList[j] > sortedList[j + 1])
                        {
                            int temp = sortedList[j];
                            sortedList[j] = sortedList[j + 1];
                            sortedList[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (sortedList[j] < sortedList[j + 1])
                        {
                            int temp = sortedList[j];
                            sortedList[j] = sortedList[j + 1];
                            sortedList[j + 1] = temp;
                        }
                    }
                }
            }

            return sortedList;
        }
    }
}
