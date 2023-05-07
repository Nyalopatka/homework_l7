int[,] Array(int xsize,int ysize,int min,int max)
{
    Console.Clear();
    int [,] array = new int[xsize,ysize];
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
void Findelement(int[,]array,int row,int col)
{
if (row > array.GetLength(0) | col > array.GetLength(1))
{
    Console.WriteLine($"{row},{col} -> такого элемента в массиве нет");
}
else
{
    int res = array[row-1,col-1];
    Console.WriteLine($"{row},{col} -> {res}");
}
}

Console.Write("введите кол-во строк: ");
int xsize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите кол-во столбцов: ");
int ysize = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение в таблице: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение в таблице: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] matrix =Array(xsize,ysize,min,max);
Console.Write("введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер ряда: ");
int col = Convert.ToInt32(Console.ReadLine());
Findelement(matrix,row,col);