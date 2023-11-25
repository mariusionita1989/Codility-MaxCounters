using System.Runtime.CompilerServices;

namespace Codility_MaxCounters
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int[] solution(int N, int[] A)
        {
            int M = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
                M >= RANGE_LOWEST_VALUE && M <= RANGE_HIGHEST_VALUE) 
            {
                int[] counters = new int[N];
                int maxCounter = 0;
                int baseValue = 0;

                foreach (int operation in A)
                {
                    if (operation >= 1 && operation <= N)
                    {
                        int counterIndex = operation - 1;
                        counters[counterIndex] = Math.Max(counters[counterIndex], baseValue) + 1;
                        maxCounter = Math.Max(maxCounter, counters[counterIndex]);
                    }
                    else
                        if (operation == N + 1)
                        baseValue = maxCounter;
                }

                for (int i = 0; i < N; i++)
                    counters[i] = Math.Max(counters[i], baseValue);

                return counters;
            }
            
            return Array.Empty<int>();
        }
    }
}
