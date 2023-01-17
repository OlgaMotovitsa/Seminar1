// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


System.Console.WriteLine ("введите число");
int number = Convert.ToInt32(Console.ReadLine());

for (int currentNumber = 1; currentNumber <= number; currentNumber ++ )
 if (currentNumber % 2==0)
 {
     System.Console.Write (currentNumber+ " " );
 }










