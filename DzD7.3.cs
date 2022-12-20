// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[new Random().Next(3, 5), new Random().Next(3, 5)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
          matrix[i, j] = new Random().Next(0, 12);
          Conssole.Write(matrix[i, j] + " ");
     }
     Console.WriteLine();
}
Console.WriteLine("_________________");

double sum = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
          sum += matrix[i, j];
     }
     double average = Math.Round(sum/matrix.GetLength(0), 2);
     sum = 0;
     Consssole.Write(average+ " ");
}
