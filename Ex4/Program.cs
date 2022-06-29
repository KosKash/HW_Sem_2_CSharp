/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
string[] dayname = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int daynum = Prompt("Какой сегодня день недели от 1 до 7 соответсвенно? ");
int i = daynum - 1;
if (daynum < 8 & daynum > 0)
{
    if (daynum > 5 && daynum < 8) Console.WriteLine("Сегодня " + dayname[i] + " выходной день");
    if (0 < daynum && daynum < 6) Console.WriteLine("Сегодня " + dayname[i] + " будний день");
}
else
{
    Console.WriteLine("Введено некоректное число");
}