// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
            Console.Write(num2d[i,j] + " ");
        }
        Console.WriteLine();
    }   
}

int[,] mult(int[,] num2d, int[,] num2d2)
{
    int[,] m = new int[num2d.GetLength(0), num2d2.GetLength(1)];
 
    for (int i = 0; i < num2d.GetLength(0); ++i)
        for (int j = 0; j < num2d2.GetLength(0); ++j)
            for (int k = 0; k < num2d2.GetLength(1); ++k)
                m[i, k] += num2d[i, j] * num2d2[j, k];
    return m;
}
 
    
void Task58()
{
    int [,] num2d = new int [2,2];
    FillArray(num2d);
    PrintArray(num2d);
    Console.WriteLine();

    int [,] num2d2 = new int [2,2];
    FillArray(num2d2);
    PrintArray(num2d2);
    Console.WriteLine();

    Console.WriteLine($"Произведение 2-х матриц: ");
    Console.WriteLine();

    int[,] m = mult(num2d, num2d2);
         for (int i = 0; i < num2d.GetLength(0); ++i)
         {
            for (int j = 0; j < num2d2.GetLength(1); ++j)
            {
               Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
}

Task58();