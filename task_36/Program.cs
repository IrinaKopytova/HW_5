// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int[] array = new int [5];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(", ", array));
Console.WriteLine();

int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine("Сумма элементов: " + sum);