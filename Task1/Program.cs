// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//int[] myArray = CreateArray(12,-9,9);
//ShowArray(Array);

int[] CreateRandomArray(int N, int start, int end){  //Функция генирации масива случайными цифрами с заданой длиной и прмежутком от до
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array){   //Функция вывода массива на экран
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int GetNumEven(int[] array) //Функция нахождения количество чётных чисел в массиве
{
int even = 0;
foreach (var num in array)  // Цикл foreach проходит по каждуму элементу num массива Array
{
    if (num % 2 == 0) even++;
}
return even;
// // for (int i=0; i < Array.Length; i++)  // Цикл проходит по каждуму элементу массива
// {  
//     if (Array[i] % 2 == 0) // Цикл проверяет элемент массива на чётность
//     even = i;      // Записываем в переменную количество чётных чисел
// }

}

int [] Array = CreateRandomArray(5, 100, 999);
ShowArray(Array);
Console.WriteLine($"количество чётных чисел = {GetNumEven(Array)}");
