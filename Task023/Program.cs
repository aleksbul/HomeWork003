// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int i;
if (n >= 1) i = 1;
else i = -1;

for (int start = 1; Math.Abs(start) <= Math.Abs(n); start += i)
{
    double cube = Math.Pow(start, 3);
    Console.WriteLine(cube);
}
