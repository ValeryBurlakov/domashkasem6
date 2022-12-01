// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Здравствуйте. Будем считать количество чисел больше 0!");
bool input = true;
int count = 0;
while (input == true)
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        count = count + 1;
        Repeat:
        Console.WriteLine("Хотите ввести ещё число?(да/нет):");
        string? answer = Console.ReadLine();
        if (answer?.ToLower() == "да")
        {
        input = true;
        }
        else if (answer?.ToLower() == "нет")
        {
            Console.WriteLine($"Вы ввели чисел больше 0: {count}. Всего доброго!");
            input = false;
        }
        else
        {
            Console.WriteLine("вы ввели ответ неправильно. Либо 'да' либо 'нет' !!!");
            goto Repeat;
        }
    }
    else 
    {
        Repeat2:
        Console.WriteLine("Хотите ввести ещё число?(да/нет):");
        string? answer = Console.ReadLine();
        if (answer?.ToLower() == "да")
        {
        input = true;
        }
        else if (answer?.ToLower() == "нет")
        {
            Console.WriteLine($"Вы ввели чисел больше 0: {count}. Всего доброго!");
            input = false;
        }
        else
        {
            Console.WriteLine("вы ввели ответ неправильно. Либо 'да' либо 'нет'!!!");
            goto Repeat2;
        }
    }
}



// Console.Write("Введите числа через пробел: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Количество элементов больше 0: {count}");



