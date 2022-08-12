// Написать программу для разворота массива

//объявили, заполнили случайными числами, вывели на экран
int[] array = new int[10];
Random r = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(-10, 10);
    Console.Write("{0}\t", array[i]);
}

//переворачиваем
for (int i = 0, j = array.Length - 1; i < j; i++, j--)
{
    int t = array[i];
    array[i] = array[j];
    array[i] = t;
}



//снова выводим на экран
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0}\t", array[i]);
}
