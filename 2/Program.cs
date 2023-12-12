//Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = {2, 2, 4, 25, 14, 8, 40, 89, 10, 55};
int result = 0;

for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0)
    result++;
}
for (int i = 0; i < array.Length; i++){
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел: {result}");