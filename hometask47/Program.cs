double[,] Matr(int rows,int cols,int min,int max)
{
    double [,] matrix = new double[rows,cols];
for(int i = 0;i < rows;i++)
{
    for(int j = 0;j < cols;j++)
    {
        matrix[i,j] =Math.Round((new Random().Next(min,max)) + (new Random().NextDouble()),1);
    }
}
return matrix;
}
void ShowMatr(double [,] matr)
{
for(int i = 0;i < matr.GetLength(0);i++)
{
    for(int j = 0;j< matr.GetLength(1);j++)
    {
        Console.Write($" |{matr[i,j]}| ");
    }
    Console.WriteLine();
}
}
Console.Write("введите кол-во строк в таблице: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("введите кол-во столбцов в таблице: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение в таблице: ");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение в таблице: ");
int maxV = Convert.ToInt32(Console.ReadLine());
double[,] mat = Matr(m,n,minV,maxV);
ShowMatr(mat);
