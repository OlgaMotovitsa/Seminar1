// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



System.Console.WriteLine ("введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2==0)
{
    System.Console.WriteLine ("Четное");
}
else
{
    System.Console.WriteLine ("Нечетное");
} 