/* Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.*/
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int num = Prompt("Введите число ");
if (num > 100)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine("Третья цифра от числа - " + result);
}
else
{
    Console.WriteLine("В числе - " + num + " третьей цифры нет");
}