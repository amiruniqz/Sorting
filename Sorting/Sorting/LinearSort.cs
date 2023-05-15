using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sorting
{
    public class LinearSort : ISort
        {
            public List<int> Sort(List<int> list, bool ascending = true)
            {
                List<int> sortedList = new List<int>(list);

                for (int i = 0; i < sortedList.Count - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < sortedList.Count; j++)
                    {
                        if (ascending)
                        {
                            if (sortedList[j] < sortedList[minIndex])
                            {
                                minIndex = j;
                            }
                        }
                        else
                        {
                            if (sortedList[j] > sortedList[minIndex])
                            {
                                minIndex = j;
                            }
                        }
                    }

                    if (minIndex != i)
                    {
                        int temp = sortedList[i];
                        sortedList[i] = sortedList[minIndex];
                        sortedList[minIndex] = temp;
                    }
                }

                return sortedList;
            }
        }
    
}
