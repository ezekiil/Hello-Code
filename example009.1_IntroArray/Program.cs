int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2; 
    if (arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6   7   8   9 
int [] array = {11, 21, 31, 41, 51, 61, 17, 18, 19, 10};
array[0] = 12; // изменение значения первого элемента массива
System.Console.WriteLine($"Четвертый элемент массива: {array[4]}"); // вывод значения четвертого элемента массива

int max = Max(array[0], array[1], array[2]);
for (int i = 3; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}
System.Console.WriteLine($"Максимальное число: {max}");

