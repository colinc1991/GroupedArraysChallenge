using ClassLibrary;

IRandomArrayGenerator randomArrayGenerator = new RandomArrayGenerator();
IArraySplitter arraySplitter = new ArraySplitter();

Console.WriteLine("Enter the length of the array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of sub-arrays to return: ");
int numSubArrays = Convert.ToInt32(Console.ReadLine());

var randomArray = randomArrayGenerator.GetRandomArray(arrayLength);
var splitArray = arraySplitter.GetSplitArray(randomArray, numSubArrays);

Console.WriteLine("Original array:");
Console.WriteLine(String.Join(", ", randomArray));

Console.WriteLine($"Length of array: {splitArray.Length}");
for (int i = 0; i < splitArray.Length; i++)
{
    Console.WriteLine($"Sub array element {i} contents: ");
    Console.WriteLine(String.Join(", ", splitArray[i]));
}