using System.Collections;
using System.Collections.Generic;

namespace DailyChallenge.Amazon
{
    /*
     * 
     * This problem was asked by Amazon.

        Implement a stack that has the following methods:

        push(val), which pushes an element onto the stack
        pop(), which pops off and returns the topmost element of the stack. If there are no elements in the stack, then it should throw an error or return null.
        max(), which returns the maximum value in the stack currently. If there are no elements in the stack, then it should throw an error or return null.
        Each method should run in constant time.
     * 
     */
    public class Challenge43
    {
        private ArrayList list = new ArrayList();

        public void Push(int val)
        {
            list.Add(val);
        }

        public int Pop()
        {
            var item = (int)list[list.Count-1];
            return item;
        }

        public int Max()
        {
            var max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (max < (int)list[i])
                    max = (int)list[i];
            }
            return max;
        }

        public int Count() {
            return list.Count;
        }

    }
    
}
