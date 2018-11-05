namespace DailyChallenge.LeetCode
{
    /*
     * We have some permutation A of [0, 1, ..., N - 1], where N is the length of A.
     * The number of (global) inversions is the number of i < j with 0 <= i < j < N and A[i] > A[j].
     * The number of local inversions is the number of i with 0 <= i < N and A[i] > A[i+1].
     * Return true if and only if the number of global inversions is equal to the number of local inversions.
     */
    public class GlobalAndLocalInversions
    {
        public bool IsIdealPermutation(int[] A)
        {
            int counterInAdvance = 1;
            int globalInversion = 0;
            int localInversion = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        if (i < j)
                        {
                            globalInversion++;
                        }
                    }
                }
                if (A.Length > counterInAdvance)
                {
                    if (A[i] > A[i + 1])
                    {
                        localInversion++;
                    }
                }
                counterInAdvance++;
            }

            return globalInversion == localInversion;
        }
    }
}
