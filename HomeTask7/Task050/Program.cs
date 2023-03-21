Console.Write("Введите строку: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбц: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());
int [,] array2d = CreateMatrixRndInt(9, 9, -40, 40);
PrintMatrix(array2d);
Console.WriteLine();

if(CheckingOfMatrixElement(array2d, rowsMatrix, columnsMatrix))
    {
         Console.WriteLine($"{rowsMatrix}, {columnsMatrix} -> {array2d[rowsMatrix-1, columnsMatrix-1]}");
    }
else
    {
        Console.WriteLine($"{rowsMatrix}, {columnsMatrix} -> такого элемента в массиве нет");
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

bool CheckingOfMatrixElement (int [,] matrix, int rows, int columns)
{
    if ( rows > 0 && rows <= matrix.GetLength(0) && columns > 0 && columns <= matrix.GetLength(1)) return true;
    else return false;
}