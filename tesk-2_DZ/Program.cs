// Задача 2: Напишите программу, которая выводит третью       1) 645 -> 5 
// цифру заданного числа или сообщает, что третьей цифры      2) 78 -> третьей цифры нет
//нет.                                                        3) 32679 -> 6

Console.WriteLine("Введите число  ");
int Namber = Convert.ToInt32(Console.ReadLine());

if (Namber > 99 & Namber <= 999)
{
    int result = Namber % 10;
    Console.WriteLine(result);
}
if (Namber > 999)
{
    int result2 = Namber % 100;
    int result3 = result2 / 10;
    Console.WriteLine(result3);
}

if (Namber <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
