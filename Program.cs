void FillArray(int[,]matrix, int minValue = -9, int maxValue=9)
{
    maxValue++;
    Random random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=random.Next(minValue,maxValue);
        }
    }
}
void PrintArray(int[,]matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
void Task54()
{
    //Задайте двумерный массив. Напишите программу, которая
    //упорядочит по убыванию элементы каждой строки двумерного массива
    int rows = 4;
    int colums = 3;
    int[,] matrix = new int[rows, colums];
    FillArray(matrix);
    PrintArray(matrix);
    
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<colums; j++)
        {
            for (int k=0; k<colums-j-1; k++)
            {
                if (matrix[i,k]<matrix[i,k+1])
                {
                    (matrix[i,k],matrix[i,k+1]) = (matrix[i,k+1],matrix[i,k]);
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Массив по убыванию:");
    PrintArray(matrix);
}
void Task56()
{
    // Задайте прямоугольный двумерный массив. Напишите программу, 
    //которая будет находить строку с наименьшей суммой элементов
    int rows = 4;
    int colums = 5;
    int[,] matrix = new int[rows, colums];
    FillArray(matrix);
    PrintArray(matrix);
    
    int min_sum = Int32.MaxValue;
    int min_index=0;
    for (int i=0; i<rows; i++)
    {
        int sum = 0;
        for (int j=0; j<colums; j++)
        {
            sum+=matrix[i,j];
        }
        if (min_sum>sum)
        {
            min_sum=sum;
            min_index=i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма: {min_sum}. Строка: {min_index + 1}");

}
void Task58()
{
    //Заполните спирально массив 4 на 4 числами от 1 до 16
    int rows = 4;
    int colums = rows;
    int[,] matrix = new int[rows, colums];
    
    int i =0;
    int j =0;
    int delta_i = 0;
    int delta_j = 1;
    int steps = colums;
    int turns = 0;
    for (int k=0; k<matrix.Length; k++)
    {
        matrix[i,j] = k + 1;
        steps--;
        //Console.Write($"{matrix[i,j]} ");
        if (steps==0)
        {
            steps = rows-1-turns/2;
            turns++;
            int temp = -delta_i;
            delta_i = delta_j;
            delta_j = temp;
            
        }
        i+=delta_i;
        j+=delta_j;
        
    }
    PrintArray(matrix);
}
Task58();