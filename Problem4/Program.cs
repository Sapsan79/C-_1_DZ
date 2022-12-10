Console.Write("Введите первое число ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int z = int.Parse(Console.ReadLine());
int max = x;

if (y > max)
{
    max = y;
}
if (z > max)
{
    max = z;
}
Console.WriteLine(max);