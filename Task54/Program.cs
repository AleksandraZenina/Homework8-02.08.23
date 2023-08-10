// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void ChangeElements (int[,] num2d)
{
   for (int i = 0; i < num2d.GetLength(0); i++)
   {
     for (int j = 0; j < num2d.GetLength(1); j++)
     {
       for (int k = 0; k < num2d.GetLength(1) - 1; k++)
       {
         if (num2d[i, k] < num2d[i, k + 1])
         {
            int temp = num2d [i, k + 1];
            num2d[i, k + 1] = num2d[i, k];
            num2d[i, k] = temp;
         }
       }
     }
   }
}

void Task54()
{
    int [,] num2d = new int [4,3];
    FillArray(num2d);
    PrintArray(num2d);
    Console.WriteLine();
    ChangeElements(num2d);
    PrintArray(num2d);
}

Task54();