// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[8];
int max = 0;
int min = 9;

int[] GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        if (array[i] > max)
        {
            max = array[i];
         
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        
    }
    return array;
    
}
GetArray(array);

Console.WriteLine(String.Join(" ", array));

Console.WriteLine("максиальное число " +max);
Console.WriteLine("минимальное число " +min);
Console.WriteLine("разница число " +(max-min));
