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

bool CheckPositionExists(int[,] arr,int row, int column)
{
    if(arr.GetLength(0)-1<row || arr.GetLength(1)-1<column) return false;
    else return true;
}

int[,] newMatrix = CreateMatrix(3,4,1,10);
PrintMatrix(newMatrix);

Console.WriteLine("Input row and column of an element");
int elementRow = Convert.ToInt32(Console.ReadLine());
int elementColumn = Convert.ToInt32(Console.ReadLine());

if(CheckPositionExists(newMatrix,elementRow,elementColumn)) Console.WriteLine(newMatrix[elementRow,elementColumn]);
else Console.WriteLine("There is no such element");
