// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillArray (int [,] num2d)
{
    Random rnd = new Random();
    for (int i = 0; i < num2d.GetLength(0); i++)
    {
       for (int j = 0; j < num2d.GetLength(1); j++)
       {
           num2d [i,j]=rnd.Next(10); 
       }
    }
}

void PrintArray (int [,] num2d)
{
    for(int i=0; i<num2d.GetLength(0); i++)
    {
        for (int j = 0; j < num2d.GetLength(1); j++)
        {
            Console.Write(num2d[i,j] + "\t");
        }
        Console.WriteLine();
    }   
}

int SumLine(int[,] num2d, int i)
{
    int sum = num2d[i,0];
    for (int j = 1; j < num2d.GetLength(1); j++)
    {
       sum += num2d[i,j];
    }
    return sum;
}


void Task56()
{
    int [,] num2d = new int [4,3];
    FillArray(num2d);
    PrintArray(num2d);
    Console.WriteLine();
    int minSum = 1;
    int sum = SumLine(num2d, 0);
    for (int i = 1; i < num2d.GetLength(0); i++)
    {
      if (sum > SumLine(num2d, i))
      {
         sum = SumLine(num2d, i);
         minSum = i+1;
      }
    }
    Console.WriteLine($"\n Строка c наименьшей суммой элементов: {minSum}");
}

Task56();
