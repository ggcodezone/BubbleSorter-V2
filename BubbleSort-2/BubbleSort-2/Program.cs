using System;

namespace BubbleSort_2
{ 
    //Name: Bubble Sorter Version 2
    //Author: Gwen Kalasky
    //Date: 11/24/20
    //Synopsis: Arranges randomly generated numbers into ascending order using bubble sort
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 1; //sets the minimum and maximum values for the generated numbers (they wont exceed max, wont be under min)
            int Max = 999;

            // this declares an integer array (you can set the number of elements you want in the brackets next to "new int"
            int[] numbergen = new int[20000];
            int temp; //temporary variable used in swapping
            Random randNum = new Random();
            for (int i = 0; i < numbergen.Length; i++)
            {
                numbergen[i] = randNum.Next(Min, Max);
            }
            for (int i = 0; i < numbergen.Length; i++) //loop picks element of array
            {
                for (int k = 0; k < numbergen.Length; k++) //second loop to access the next element
                {
                    //comparing the values
                    if (numbergen[i] < numbergen[k])
                    {
                        //if the first value is greater than the second, elements are swapped
                        temp = numbergen[i];
                        numbergen[i] = numbergen[k];
                        numbergen[k] = temp;
                    }
                }
            }
            //print sorted list
            for (int i = 0; i < numbergen.Length; i++)
            {
                Console.WriteLine(numbergen[i]);

            }

        }
    }
}
