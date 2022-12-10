//2. Дни недели:
//Первое решение

Console.WriteLine("Введите номер дня недели");
int a = int.Parse(Console.ReadLine());
if (a <= 7)
{
   if (a == 1)
       Console.WriteLine("Понедельник");
   if (a == 2)
       Console.WriteLine("Вторник");
   if (a == 3)
       Console.WriteLine("Среда");
   if (a == 4)
       Console.WriteLine("Четверг");
   if (a == 5)
       Console.WriteLine("Пятница");
   if (a == 6)
       Console.WriteLine("Суббота");
   if (a == 7)
       Console.WriteLine("Воскресенье");
}
else
   Console.WriteLine("Ваше число больше дней недели");
//************************

//Второе решение
// Console.WriteLine("Введите номер дня недели");
// int number = int.Parse(Console.ReadLine());

// switch (number)
// {
//     case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     case 4:
//         Console.WriteLine("Thursday");
//         break;
//     case 5:
//         Console.WriteLine("Friday");
//         break;
//     case 6:
//         Console.WriteLine("Saturday");
//         break;
//     case 7:
//         Console.WriteLine("Sunday");
//         break;
//     default:
//         Console.WriteLine("None");
//         break;
// }
