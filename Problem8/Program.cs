// Напишите программу, которая на вход принимает число (N) а на выходе выдаёт все чётные числа от 0 до N
Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
 for (int i = 2; i <= a; i += 2) {
    Console.WriteLine (i);
 }
