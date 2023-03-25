int[,] matr1= CreateMatrixRndInt (2, 4, 0, 5);
PrintMatrix(matr1);
Console.WriteLine();
int[,] matr2= CreateMatrixRndInt (4, 3, 0, 5);
PrintMatrix(matr2);
if(CheckMultiplicationMatrix(matr1, matr2)) 
{
    int [,] multiplicationMatrix = MultiplicationMatrix(matr1, matr2);
    Console.WriteLine("Результат перемножения матриц:");
    PrintMatrix(multiplicationMatrix);
}
else
{
    Console.WriteLine("Error: Число столбцов первой матрицы не равняется числу строк второй мартицы. Перемножение невозможно.");
}

int [,] MultiplicationMatrix(int [,] matrix1, int [,] matrix2)
{
    int [,] result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                result[i,k] = result[i,k] + matrix1 [i,j] * matrix2[j,k];
            }
        }
    }
  return result;
}



bool CheckMultiplicationMatrix(int [,] matrix1, int [,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
    else return false;
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




