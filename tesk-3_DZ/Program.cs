// Программа которая принимает на вход цифру обозначающую день
// недели и проверяет является ли это цифра выходным днем

Console.WriteLine("Введите число от 1 до 7 ");
int Namber =Convert.ToInt32(Console.ReadLine());

if (Namber <=5)
{
    Console.WriteLine("Этот день недели не выходной  ");
}
else 
{
    Console.WriteLine("Это цифра обозначает выходной день в неделе  ");
}
