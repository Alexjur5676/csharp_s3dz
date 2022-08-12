// Написать программу для разворота массива

// первый способ 

int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int length = array.Length;
int i = 0;
int halfLength = length / 2;
while (i < length)
{
    Console.Write(array[i]);
    Console.Write(" ");
    i++;
}
Console.WriteLine(" ");
i = 0;
while (i < halfLength)
{
    int temp = array[i];
    array[i] = array[length - i - 1];
    array[length - i - 1] = temp;
    i++;
}
i = 0;
while (i < length)
{
    Console.Write(array[i]);
    Console.Write(" ");
    i++;
}
Console.WriteLine("");

//второй способ 

// int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// Console.WriteLine(string.Join(" ", array));
// for (int i = 0; i < array.Length / 2; i++)
// {
//     (array[i], array[array.Length - (i + 1)]) = (array[array.Length - (i + 1)], array[i]);
// }
// Console.WriteLine(string.Join(" ", array));

// третий способ
// int[] array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// Console.WriteLine(string.Join(" ", array));
// Array.Reverse(array);
// Console.WriteLine(string.Join(" ", array));

