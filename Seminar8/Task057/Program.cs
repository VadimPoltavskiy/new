int[,] arr2d = CreateMatrixRndInt(10, 10, 0, 10);
PrintMatrix(arr2d);
int [] arr = ConvertMatrixToArray(arr2d);
Array.Sort(arr);
Console.WriteLine();
int[,] frequencyDictionary = FrequencyDictionary(arr);
PrintFrequencyDictionary(frequencyDictionary);


int [] ConvertMatrixToArray( int [,] matrix)
{
    int[] array = new int [matrix.Length];
    int k =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array [k] = matrix[i, j];
            k++;
        }
    }
    return array;

}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    }
}
int [,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //перебор строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //перебор столбцов
        {
            matrix [i,j] = rnd.Next(min, max+1);
        }
    }
    return matrix;
}
int UniqueDigits ( int [] array)
{
    int value = array [0];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (value != array[i])
        {
            value =array[i];
            count++;
        }
    }
    return count;
}

int [,] FrequencyDictionary ( int [] array)
{
    int[,] dictionary =new int [UniqueDigits(array), 2];
    int value = array[0];
    int count = 0;
    int numberElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (value == array[i]) count++;
        else
        {
            dictionary[numberElem,0] = value;
            dictionary[numberElem,1] = count;
            value = array[i];
            count= 1;
            numberElem++;
        }
    }
    dictionary[numberElem,0] = value;
    dictionary[numberElem,1] = count;
   return dictionary;
}

void PrintFrequencyDictionary(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine($"{matrix[i, 0]} встречается {matrix[i,1]} раз(а)");
    }
}