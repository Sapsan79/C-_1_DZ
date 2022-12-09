// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//           какое число больше, а какое меньше
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, неравное первому ");
int b = int.Parse(Console.ReadLine());
if (a != b)
    {if (a < b) {
        Console.WriteLine("Первое число меньше второго");
        }
    if (a > b) {
        Console.WriteLine("Первое число больше второго");
        }}
else
{
    Console.WriteLine("Ввод неверен: ввели  одинаковые цифры");
}        
