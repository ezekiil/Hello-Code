﻿int [] array = new int [10]; // Создаем массив из 10 элементов
int n = array.Length; // количество элементов массива
int find = 18; // искомый элемент
int index = 0; 
while (index < n) // поиск индекса искомого элемента
{
    if (array[index] == find) // проверка на то, что значение элемента массива равно значению переменной find
    {
        System.Console.WriteLine($"Индекс максимального элемента: {index}");
        break; // выход из цикла, если нашли первый заданный искомый элемент
    }
    index++;
}