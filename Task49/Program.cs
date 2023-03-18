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

int[,] SquareIndexesEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i%2==0 && j%2==0) array[i,j] *= array[i,j];
        }
    }
    return array;
}

int[,] newArray = CreateMatrix(3,5,1,100);
PrintMatrix(newArray);

Console.WriteLine();

SquareIndexesEven(newArray);
PrintMatrix(newArray);


