/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(n);

if ( a.Length == 5 )
{
    if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}