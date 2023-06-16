// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine(" До какого числа выводить ");


int x = Convert.ToInt32(Console.ReadLine());

double otv = 1;

if (x > 0)
{
    for (int i = 1; i <= x; i++)
    {
        otv = Math.Pow(i, 3);
        Console.Write(otv + " , ");

    }
}
else
{
    Console.WriteLine("Вы вели не коректное число");
}



