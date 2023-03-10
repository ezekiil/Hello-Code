void FillArray(int[] collection) // заполнение массива случайными числами
{
    int length = collection.Length; // длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) // вывод массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find) // поиск индекса искомого элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int pos = IndexOf(array, 4);
System.Console.WriteLine($"Индекс первого числа четыре: {pos}");