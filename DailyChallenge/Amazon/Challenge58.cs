using System;
using System.Collections.Generic;
using System.Text;



namespace DailyChallenge.Amazon
{

    /*
     * An sorted array of integers was rotated an unknown number of times.
     * Given such an array, find the index of the element in the array in faster than linear time. If the element doesn't exist in the array, return null.
     * For example, given the array [13, 18, 25, 2, 8, 10] and the element 8, return 4 (the index of 8 in the array).
     * You can assume all the integers in the array are unique.
     */
    public class Challenge58
    {

        public int IndexOf(int[] array, int element)
        {
            var list = new int[13, 18, 25, 2, 8, 10];
            Array.Sort(list);
            return 1;
            //return findIndex(list , 0, list.Length-1, element);
        }


        private int findIndex(int[] array, int l, int r, int key) {

            return 0;
            //return null;
        }



    }
}
