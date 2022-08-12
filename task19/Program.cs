// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первый способ решения
Console.WriteLine("Введите число");
string number = Console.ReadLine();
if (number.Length != 5)
{
    Console.WriteLine($"Число {number} не  является пятизначным!");
}
else
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

// Второй способ решения
// Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// if (number.Length != 5)
// {
//     Console.WriteLine($"Число {number} не  является пятизначным!");
// }
// else
// {
//     int halfLength = number.Length / 2;
//     int i = 0;
//     bool isPalyndrome = true;
//     while (i <= halfLength)
//     {
//         if (number[i] != number[number.Length - i - 1])
//         {
//             isPalyndrome = false;
//             break;
//         }
//         i++;
//     }
//     if (isPalyndrome)
//     {
//         Console.WriteLine($"Число {number} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} не является палиндромом");
//     }

// }