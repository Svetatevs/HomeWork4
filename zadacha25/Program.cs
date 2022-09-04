// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double B = Convert.ToDouble(Console.ReadLine());

double Pow(double a, double b)
{
    double result = a * b;
    return result;
}
double x = Math.Pow(A, B);
Console.WriteLine($"Число А в степени В равно: {x}");

