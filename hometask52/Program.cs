double[,] Array(int xsize,int ysize,int min,int max)
{
    Console.Clear();
    double [,] array = new double[xsize,ysize];
    for(int i = 0;i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(min,max+1);
            Console.Write($" |{array[i,j]}| ");
        }
        Console.WriteLine();
    }
return array;
}
void Average(double[,]matrix)
{
    Console.Write("среднее ариф. каждого столбца: ");
    for(int i = 0;i < matrix.GetLength(1);i++)
    {
        double count = 0;
        double res = 0;
        for(int j = 0;j < matrix.GetLength(0);j++)
        {
            count += matrix[j,i];
        }
        res = Math.Round(count / matrix.GetLength(0),1);
        Console.Write($"|{res}");
    }
    Console.Write("| ");
        Console.WriteLine();
}
Console.Clear();
Console.Write("введите кол-во строк: ");
int xsize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите кол-во столбцов: ");
int ysize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение в таблице: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение в таблице: ");
int max = Convert.ToInt32(Console.ReadLine());
double [,] matrix =Array(xsize,ysize,min,max);
Average(matrix);