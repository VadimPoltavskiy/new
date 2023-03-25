int [,] matrix = new int [3,4];
PrintMatrix(matrix);
//table[0,0], ....table[0,4]
//table[1,0] 
FillArray(matrix);
Console.WriteLine();
PrintMatrix(matrix);

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
int [,] FillArray(int [,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)   //перебор строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //перебор столбцов
        {
            matrix [i,j] = new Random().Next(1,10);
        }
    }
    return matrix;
}