namespace ClassLibrary
{
    public class ArraySplitter : IArraySplitter
    {
        /// <summary>
        /// Will return a 2 dimensional array. The array will have a length of numSubArrays. Each subarray will contain an evenly distributed number of integers based on the originalArray.
        /// </summary>
        /// <param name="originalArray">Array to split into several subarrays.</param>
        /// <param name="numSubArrays">The number of subarrays to return.</param>
        public int[][] GetSplitArray(int[] originalArray, int numSubArrays)
        {
            int arrayLength = originalArray.Length;
            int minimumLength = arrayLength / numSubArrays;
            int remainder = arrayLength % numSubArrays;
            int[][] result = new int[numSubArrays][];
            int originalArrayIndex = 0;

            for (int i = 0; i < numSubArrays; i++)
            {
                int subArrayLength = GetSubArrayLengthIncludingRemainder(minimumLength, remainder);
                result[i] = GetSubArray(subArrayLength, originalArray, ref originalArrayIndex);
                remainder--;
            }

            return result;
        }

        /// <summary>
        /// Returns the expected length of the subarray based on the minimum length of the array and any remainder needing added.
        /// </summary>
        /// <param name="minimumLength">The bare minimum length of the array.</param>
        /// <param name="remainder">Any remainder needing distributed among the subarrays.</param>
        private static int GetSubArrayLengthIncludingRemainder(int minimumLength, int remainder)
        {
            if (remainder > 0)
            {
                // remainder needs added, add 1 as a bare minimum to the length of the array
                return minimumLength + 1;
            }
            
            return minimumLength;
        }

        /// <summary>
        /// Will return an array of integers of a given size based on the originalArray parameter. The array will contain the values of the indices of the originalArray.
        /// </summary>
        /// <param name="arrayLength">Length of the array to return.</param>
        /// <param name="originalArray">Array to take values from.</param>
        /// <param name="originalArrayIndex">Current index of the originalArray.</param>
        /// <remarks>originalArrayIndex is passed by reference so its value can be incremented</remarks>
        private static int[] GetSubArray(int arrayLength, int[] originalArray, ref int originalArrayIndex)
        {
            int[] subArray = new int[arrayLength];

            for (int j = 0; j < arrayLength; j++)
            {
                subArray[j] = originalArray[originalArrayIndex];
                originalArrayIndex++;
            }

            return subArray;
        }
    }
}