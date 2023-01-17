//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    System.Console.Write("max = ");
    System.Console.WriteLine(number1);
}
 else
{
     System.Console.Write("max = ");
     System.Console.WriteLine(number2);
}