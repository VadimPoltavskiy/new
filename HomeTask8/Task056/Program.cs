int[,] matr= CreateMatrixRndInt (4, 5, -5, 5);
PrintMatrix(matr);
int [] sumValuesInRows = SumValuesInRows(matr);
int row = IndexMinValueArray(sumValuesInRows) + 1;
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row} строка");

int IndexMinValueArray(int[] arr)
{
    int min = arr[0];
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int []  SumValuesInRows(int[,] matrix)
{
    int [] arr = new int [matrix.GetLength(0)];
    for (int i = 0;  i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        arr[i]=sum;
    }
    return arr;
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