// See https://aka.ms/new-console-template for more information


String[] arr = { "BCDEF", "dbaqc", "abcde", "bbbbb" };
Console.WriteLine("Input:" + string.Join(", ", arr));
// Radix is the maximum value from the input array. For a String maximum value is 26
RadixSort(arr, 26, arr[0].Length);
Console.WriteLine("Output:" + string.Join(", ", arr));

// Function to perform Radix sort on String array
static void RadixSort(String[] input, int radix, int width)
{
    for (int i = 0; i < width; i++)
    {
        PerformRadixSort(input, i, radix);
    }
}
static void PerformRadixSort(String[] input, int position, int radix)
{
    // Creating a temporary count array
    int[] countArray = new int[radix];
    var nos = input.Length;
    // Populating the count array
    foreach (String value in input)
    {
        countArray[GetDigit(position, value, radix)]++;
    }
    // Normalizing count array
    for (int i = 1; i < radix; i++)
    {
        countArray[i] = countArray[i] + countArray[i - 1];
    }
    String[] tempArray = new String[nos];
    // Building the final temporary array
    for (int i = nos - 1; i >= 0; i--)
    {
        tempArray[--countArray[GetDigit(position, input[i], radix)]] = input[i];
    }
    // Copying into the actual array
    for (int i = 0; i < nos; i++)
    {
        input[i] = tempArray[i];
    }
}
// Hashing the input value, radix = 26.
// It takes the character at (length - position) location
// and convert it to ascii value and return the ascii value
static int GetDigit(int position, String value, int radix)
{
    var nos = value.Length - 1;
    var c = value.ToLower()[nos - position];
    return (int)c - 97;
}
