/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты X,Y и Z первой точки через Enter: ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X,Y и Z второй точки через Enter: ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double scal = 0;

scal = Math.Sqrt(Math.Pow((xa-xb),2)+Math.Pow((ya-yb),2)+Math.Pow((za-zb),2));
Console.WriteLine(scal);
