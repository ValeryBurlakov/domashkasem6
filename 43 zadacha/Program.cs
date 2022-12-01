// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1 = k2 * x + b2 - сравняли уравнения
// x = (b2 - b1) / (k1 - k2); вывели x
// y = k1 * (b2 - b1) / (k1 - k2) + b1; добавили полученный x в y
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if ( x == 0)
{
    Console.WriteLine("они параллельны");
}
Console.WriteLine($"Пересечение в точке: ({x}; {y})");
