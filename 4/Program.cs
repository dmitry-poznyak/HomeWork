// Задача 4**(не обязательно): 
//Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
//Размер массива должен быть равен количеству цифр.

int num = new Random().Next(1, 100001);
Console.WriteLine($"Натуральное число в диапазоне от '1' до '100 000': {num}");

int[] array = num.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray(); //эту строку подсмотрел в интернете
                                                                                           //так как не получалось рандомное число добавить в массив 

for (int i = 0; i < array.Length; i++){
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++){
    array[i] = num % 10;
    num /= 10;
}

Console.WriteLine("Массив цифр после изменения:");
for (int i = 0; i < array.Length; i++){
    Console.Write(array[i] + " ");
}