Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину матрицы: ");
int depth = Convert.ToInt32(Console.ReadLine());

int min = 10;
int max = 99;

if(CheckFillingMatrix(rows, columns, depth, min, max)) 
{
    int [,,] matrix3D = CreateMatrix3DRndNonRepetitiveInt(rows, columns, depth, min, max);
    PrintMatrix3D(matrix3D);
}
else
{
    Console.WriteLine($"Error: Невозможно задать массив c неповторяющимися числами. Количество элементов массива {rows*columns*depth} > числа допустимых значений {max-min+1}.");
}


bool CheckFillingMatrix(int rows, int columns, int depth, int min, int max)
{
    if (rows*columns*depth <= max-min+1) return true;
    else return false;
}

int [,,] CreateMatrix3DRndNonRepetitiveInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix3D = new int[rows, columns,depth];
    Random rnd = new Random();
    for (int i = 0; i < matrix3D.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++) 
            {
                int variable = rnd.Next(min, max+1);
                while(CheckingForDuplicateValuesMatrix3D(variable, matrix3D))
                {
                    variable = rnd.Next(min, max+1);
                }
                matrix3D[i,j,k]=variable;
            
            }
        }
    }
    return matrix3D;
}

bool CheckingForDuplicateValuesMatrix3D(int var, int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++) 
            {
              if(var==matrix3D[i,j,k]) return true;
            }
        }
    }
  return false;  
}


void PrintMatrix3D (int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                 Console.Write($"{matrix[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
}




