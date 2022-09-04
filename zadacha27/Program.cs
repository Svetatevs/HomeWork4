// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
#nullable disable
Console.WriteLine("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());

int GetSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int number = 0;
        number = num % 10;
        sum = sum + number;
        num = num / 10;
    }
    return sum;
}
int result = GetSum(input);
Console.WriteLine(result);
