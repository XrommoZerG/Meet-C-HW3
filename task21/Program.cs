// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




Console.WriteLine(" 1 точка Укажите  х");

int ax = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(" 1 точка Укажите y");

int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" 1 точка Укажите z");

int az = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("2 точка  Укажите  х");
int bx = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(" 2 точка Укажите y");


int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" 2 точка Укажите z");


int bz = Convert.ToInt32(Console.ReadLine());


int kat1 = ax - bx;
int kat2 = ay - by;
int kat3 = az - bz;

if (kat1 < 0)
{
    kat1 *= -1;
}
if (kat2 < 0)
{
    kat2 *= -1;
}
if (kat3 < 0)
{
    kat3 *= -1;
}

double otv = Math.Sqrt(Math.Pow(kat1, 2) + Math.Pow(kat2, 2) + Math.Pow(kat3, 2));

Console.WriteLine("Ответ равен " +  Math.Round(otv,2));

