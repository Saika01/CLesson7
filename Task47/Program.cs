double[,] CreateMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
        {
            double num = rnd.NextDouble()*(max-min)+min;
            matrix[i,j] = Math.Round(num,1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("(^3^)/");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine("(^3^)/");
    }
}

double[,] newMatrix = CreateMatrix(3,4,-10,10);
PrintMatrix(newMatrix);
