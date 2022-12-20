// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Ввеедите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввеедите количество столбцов ");
int colums = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [rowss, colums];

for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
          matrix[i,j] = new Random().NextDouble();
          matrix[i,j] +=new Random().Next(-10, 10);
          matrix[i,j] = Math.Round(matrix[i,j], 2);
          Console.Write(matrix[i,j]+ " ");
     }
     Console.WriteLine();
}
