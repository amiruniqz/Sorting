using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sorting
{
    public class MergeSort : ISort
    {
        public List<int> Sort(List<int> list, bool ascending = true)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            int mid = list.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }

            for (int i = mid; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            left = Sort(left, ascending);
            right = Sort(right, ascending);

            return Merge(left, right, ascending);
        }
        private static List<int> Merge(List<int> left, List<int> right, bool ascending)
        {
            List<int> merged = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (ascending)
                {
                    if (left[leftIndex] <= right[rightIndex])
                    {
                        merged.Add(left[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        merged.Add(right[rightIndex]);
                        rightIndex++;
                    }
                }
                else
                {
                    if (left[leftIndex] >= right[rightIndex])
                    {
                        merged.Add(left[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        merged.Add(right[rightIndex]);
                        rightIndex++;
                    }
                }
            }

            while (leftIndex < left.Count)
            {
                merged.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                merged.Add(right[rightIndex]);
                rightIndex++;
            }

            return merged;
        }
    }
}
