//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] array = {1.25, 4.5, 3.35};
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++){
    Console.WriteLine(array[i] + " ");
}

for (int i = 0; i < array.Length; i++){
    if (array[i] > max ){
        max = array[i];
    } 
    
    if (array[i] < min){
        min = array[i];
    }
}
double result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {result}");