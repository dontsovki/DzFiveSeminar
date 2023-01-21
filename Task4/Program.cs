// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] CreateRandomArray(int N, int start, int end)     // Функция задания массива случайных вещественных чисел от -100 до 100 размером N

{       
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;

}

void ShowArray(int[] array){ // Функция вывода массива на экран
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int MaxMin(int[] array)  // функция нахождения максимума и минимума и разницы между максимальным и минимальным элементов массива
{
    int max = array[0];
    int min = array[0];
    foreach (var num in array)  // Цикл foreach проходит по каждуму элементу num массива Array
{
    if (min > num) min = num;
    if (max < num) max = num;
}
return max-min;
}


int [] Array = CreateRandomArray(5, 100, 999);
ShowArray(Array);
Console.WriteLine($"разница = {MaxMin(Array)}");

