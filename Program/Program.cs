int[] GetArray(int amountElement, int minValue, int maxValue)
{
    int[] array = new int[amountElement];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] defoltArray = GetArray(10, -99, 99);
PrintArray(defoltArray);

int GetCountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int N = GetCountEven(defoltArray);

int[] GetArrayEvenNumbers(int[] array, int size)
{
    int index = 0;
    int[] arrayEven = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            arrayEven[index] = array[i];
            index++;
        }
    }
    return arrayEven;
}

int[] evenArray = GetArrayEvenNumbers(defoltArray, N);
PrintArray(evenArray);
