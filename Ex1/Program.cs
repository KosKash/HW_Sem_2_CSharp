/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int num = Prompt("Input number ");
int a = num % 100;
int b = a / 10;
Console.Write("Second number is - " + b);