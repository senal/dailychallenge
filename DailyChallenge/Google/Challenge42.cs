using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyChallenge.Google
{

    /*
     *
     *  This problem was asked by Google.
        Given a list of integers S and a target number k, write a function that returns a subset of S that adds up to k. 
        If such a subset cannot be made, then return null.
        Integers can appear more than once in the list. You may assume all numbers in the list are positive.
        For example, given S = [12, 1, 61, 5, 9, 2] and k = 24, return [12, 9, 2, 1] since it sums up to 24.
        S = [6, 13, 7, 9, 2, 8, 1], K =19
     *
     */
    public class Challenge42
    {
        public int[] SpitSubset(int[] s, int expectedSum)
        {
            List<int> list = new List<int>();
            Array.Sort<int>(s, (a, b) => b.CompareTo(a));
            for (int i = 0; i < s.Length; i++)
            {
                var nextIndex = i + 1;
                var next_element = 0;
                if (nextIndex < s.Length)
                    next_element  = s[nextIndex];
                var current_sum = list.Sum();
                var current_element = s[i];
                if (current_element > expectedSum) continue;
                if (current_sum <= expectedSum) {
                    if (current_sum + current_element <= expectedSum)
                    {
                        if (current_element + next_element <= expectedSum)
                            list.Add(current_element);
                    };
                }
            }
            return list.ToArray();
        }
    }
}
