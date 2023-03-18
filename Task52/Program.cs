int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
        {
            matrix[i,j] = rnd.Next(min,max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("(^3^)/");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4} ");
        }
        Console.WriteLine("(^3^)/");
    }
}

void PrintArray(double[] array)
{
    Console.Write("(^3^)/ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i], 4} ");
    }
    Console.Write("(^3^)/ ");
}

double[] EveryColumnMiddleNumber(int[,] matr)
{
    double[] array = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        double sum =0;
        for (int i = 0; i < matr.GetLength(0); i++) 
        {
            sum+=matr[i,j];
        }
        array[j] = Math.Round(sum/matr.GetLength(0),1);
    }
    return array;
}

int[,] newMatrix = CreateMatrix(3,5,1,10);
PrintMatrix(newMatrix);

Console.WriteLine();

double[] newArray = EveryColumnMiddleNumber(newMatrix);
PrintArray(newArray);
