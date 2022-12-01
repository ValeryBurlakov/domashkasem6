// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int NumbersAmount(int number)
{
    if (number > 0)
    {
    return NumbersAmount(number / 10);
    }
    else
    {
        return NumbersAmount(number);
    }
}
Console.WriteLine(NumbersAmount(number));


// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2); // return потому что нам нужно вернуть значение
// }

// for(int i = 1; i < n - 1; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

// принимает на вход число и выдает количество цифр
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int number1 = number;
// while (number > 0)
// { number1 /= 10;
// count++;
// }
// Console.WriteLine($"количество цифр в числе {number} равно: {count} ");
// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num;
// int count = 0;

// while(num > 0){
//     num /= 10;
//     count++;
// }

// Console.WriteLine($"Количество цифр в числе {num1} равно {count}");