namespace ClassLibrary
{
    public class RandomArrayGenerator : IRandomArrayGenerator
    {
        private Random _random;
        
        public RandomArrayGenerator()
        {
            _random = new Random();
        }

        /// <summary>
        /// Returns an array filled with random numbers ranging from 0 - 10
        /// </summary>
        /// <param name="arrayLength">Desired length of the returned array.</param>
        public int[] GetRandomArray(int arrayLength)
        {
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = _random.Next(0, 10);
            }

            return array;
        }
    }
}
