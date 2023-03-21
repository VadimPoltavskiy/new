int [,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
double [] array = ArithmeticMeanColumnsMatrix (array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(array);



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

void PrintArrayDouble (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

double [] ArithmeticMeanColumnsMatrix (int [,] matrix)
{
       double[] arr = new double[matrix.GetLength(1)];
       double sum = 0;
       double result = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)   //перебор столбцов
    {
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) //перебор строк
        {
            sum += matrix [i,j];
        }
        result = sum/matrix.GetLength(0);
        arr[j] = Math.Round(result, 1);
    }
    return arr;
}