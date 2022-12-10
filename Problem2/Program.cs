// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//           какое число больше, а какое меньше
Console.Write("Введите первое число a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число b = ");
int b = int.Parse(Console.ReadLine());
if (a != b)
    {if (a < b) {
        int max = b;
        Console.Write("max = ");
        Console.WriteLine(max);}
        
    if (a > b) {
        int max = a;
        Console.Write("max = ");
        Console.WriteLine(max);
    }}
 else
 {Console.WriteLine("Ввод неверен: ввели  одинаковые цифры");}
        
