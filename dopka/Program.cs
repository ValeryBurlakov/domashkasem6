// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5
Console.WriteLine("Введите число, а мы покажем количество цифр в нём:");
int number = Convert.ToInt32(Console.ReadLine());
int NumbersAmount(int number)
{
    if (number / 10 > 0)
    {
        return NumbersAmount(number / 10) + 1;
    }
    else
    {
        return 1;
    }
}
Console.WriteLine($"В числе {number} количество цифр равно: {NumbersAmount(number)}");