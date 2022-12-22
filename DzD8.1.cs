// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите кол-во колонов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
int[,] GerArray()
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
         
              array[i, j] = new Random().Next(0, 10);
         }
    }
    return array;
}
void PrintArray(int[,] array)
{
 
      for (int i = 0; i < array.GetLength(0); i++)
      {
           for (int j = 0; j < array.GetLength(1); j++)
           {
           
                 Console.Write(array[i, j]);
           }
           Console.WriteLine();
       }
}
void ChangeArray(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1)-1; k++)
                {
                     if (array[i, k] < array[i, k + 1])
                     {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                     }
                 }
            }
        }
}

PrintArray(GetArray());
Console.WriteLine("______________");
ChangeArray(array);
PrintArray(array);
