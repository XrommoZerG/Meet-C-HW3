// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да






Console.WriteLine("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

int otv = 0, dig, n;

n = number;

while (n > 0)
{
    dig = n % 10;

    otv = otv * 10 + dig;

    n /= 10;

}

 if (otv == number)
{
    Console.WriteLine("Число полиндром");
}
else
{
    Console.WriteLine("Число НЕ! полиндром");
}