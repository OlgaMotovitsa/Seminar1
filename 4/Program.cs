// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	// 3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Введите номер дня недели");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 1)
{
   Console.WriteLine("Это понедельник"); 
}
else if (number1 == 2)
{
   Console.WriteLine("Это вторник"); 
}
else if (number1 == 3)
{
   Console.WriteLine("Это среда"); 
}
else if (number1 == 4)
{
   Console.WriteLine("Это четверг"); 
}
else if (number1 == 5)
{
   Console.WriteLine("Это пятница"); 
}
else if (number1 == 6)
{
   Console.WriteLine("Это суббота"); 
}
else if (number1 == 7)
{
   Console.WriteLine("Это воскресение"); 
}
else Console.WriteLine("Не является днем недели");
