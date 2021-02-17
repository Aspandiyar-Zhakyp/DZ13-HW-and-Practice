using System;
using System.Collections.Generic;

namespace CollectionsHW
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>() { 47, 70, 1086, 2855, 3433, 3735, 1472, 9352, 4556, 7552 };
            var sum = 0;
            var maxValue = 0;
            var secondMaxValue = 0;
            var indexOfSecondMaxValue = 0;
            foreach (var Element in list)
            {
                if (list.IndexOf(Element) % 2 == 0)
                {
                    sum += Element;
                }
                if (maxValue < Element)
                {
                    secondMaxValue = maxValue;
                    maxValue = Element;
                    indexOfSecondMaxValue = list.IndexOf(secondMaxValue);
                }
                else if (maxValue > Element && secondMaxValue < Element)
                {
                    secondMaxValue = Element;
                    indexOfSecondMaxValue = list.IndexOf(secondMaxValue);
                }
            }
            Console.WriteLine($"Second max value: {secondMaxValue}, Index = {indexOfSecondMaxValue}");
            Console.WriteLine($"Sum of even elements: {sum}");

            var bubbleList = new BubbleList() { 3, 7, 1, 8, 6, 0, 5, 9, 4, 10 };
            bubbleList.BubbleSort();
            foreach (var element in bubbleList)
            {
                Console.Write(element);
            }
        }
    }
}
