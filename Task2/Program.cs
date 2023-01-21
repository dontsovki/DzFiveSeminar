// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int N, int start, int end){ //Функция генирации масива случайными цифрами с заданой длиной и прмежутком от до
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array){   // Функция вывода массива на экран

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int GetNumEven(int[] array) //Функция нахождения cумму элементов, стоящих на нечётных позициях
{
int even = 0;
for (int i=0; i < array.Length; i++){  // Цикл проходит по каждуму элементу массива
    if (array[i] % 2 == 1) // Цикл проверяет элемент массива на чётность
    even += array[i];
}
return even;
}

// int even = 0;

// for (int i=0; i < Array.Length; i++){  // Цикл проходит по каждуму элементу массива
//     if (i % 2 != 1) // Цикл проверяет элемент массива на чётность
//     even += Array[i];      // Записываем в переменную количество чётных чисел
// }

int [] Array = CreateRandomArray(3, 0, 100);
ShowArray(Array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {GetNumEven(Array)}");

