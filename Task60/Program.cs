// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray (int [,,] num3d)
{
    Random rnd = new Random();
    for (int i = 0; i < num3d.GetLength(0); i++)
    {
       for (int j = 0; j < num3d.GetLength(1); j++)
       {
          for (int k = 0; k<num3d.GetLength(2); k++)
          {
             num3d [i,j,k]= rnd.Next(10,100); 
             for (int m = 0; m < k; m++)
                if (num3d[i,j, m] == num3d[i, j,k]) m--;
          }
        }
    }
}

void PrintArrayLinebyLine (int [,,] num3d)
{
    for(int i=0; i<num3d.GetLength(0); i++)
    {
        for (int j = 0; j < num3d.GetLength(1); j++)
        {
            for (int k = 0; k<num3d.GetLength(2); k++)
            {
                            
                Console.Write($"[{i},{j},{k}] = {num3d[i,j,k]}  ");
            }            
        }
        Console.WriteLine();
    }   
}

void Task60()
{
    int [,,] num3d = new int [2,2,2];
    FillArray(num3d);
    PrintArrayLinebyLine(num3d);
}

Task60();
