using Sorting.Sorting;
using System;
using System.Collections.Generic;

namespace Sorting
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 9, 1, 3 ,3,4,5,1,2,3,40};
            
            ISort linearSort = new LinearSort();
            ISort bubbleSort = new BubbleSort();
            ISort mergeSort = new MergeSort();

            //OneClassToRuleThemAll ruleThemAll = new OneClassToRuleThemAll(linearSort);
            //OneClassToRuleThemAll ruleThemAll = new OneClassToRuleThemAll(bubbleSort);
            OneClassToRuleThemAll ruleThemAll = new OneClassToRuleThemAll(mergeSort);
            List<int> sortedNumbers = ruleThemAll.PerformSort(numbers, ascending: false);


            
            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
