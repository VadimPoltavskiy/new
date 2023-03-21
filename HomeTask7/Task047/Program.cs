Console.WriteLine("Введите число строк:");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
double [,] array2d = CreateMatrixRndDouble(rowsMatrix, columnsMatrix, 1, 50);
PrintMatrix(array2d);
Console.WriteLine();

double [,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double [,] matrix = new double [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //перебор строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //перебор столбцов
        {
            double num = rnd.NextDouble()*(max-min) + min;
            matrix [i,j] = Math.Round(num, 1);
        }
    }
    return matrix;
}

void PrintMatrix (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine();
    }
}