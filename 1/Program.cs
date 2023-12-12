//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = {2, 2, 4, 25, 14, 8, 40, 89, 10, 55};
int num = 20;
int num1 = 90;
int result = 0;

for (int i = 0; i < array.Length; i++){
    if (array[i] >= num && array[i] <= num1)
    result++;
}
Console.WriteLine(result);