/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число:  ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
double b = 0;

while (count <= a)
{
    b = Math.Pow(count,3);
    Console.WriteLine(b);
    count++;
}