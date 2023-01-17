// на входе 456 а на выходе даст последнюю 6 (% подсказка)

System.Console.WriteLine ("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int LastDight = number % 10;
System.Console.WriteLine (LastDight);