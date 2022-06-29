/*Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.*/
Console.Clear();
int a = new Random().Next(100, 999);
int first = a / 100;
int second = a % 10;
int result = first*10+second;
Console.WriteLine("Из числа " + a + " получается число " + result);