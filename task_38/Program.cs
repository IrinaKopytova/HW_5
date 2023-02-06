// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7

double[] FillArrayWithRandom(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(0, 100)) / 10;
    }
    return array;
}

double[] array = new double [5];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join("; ", array));
Console.WriteLine();

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
double diff = max - min;
Console.WriteLine("Максимальное значение  = " + max);
Console.WriteLine("Минимальное значение = " + min);
Console.WriteLine("Разница между max и min = " + diff);