// от минус 4 до плюс 4


// получили число 
// умножили на -1
// цикл до числа , кот ввели 

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int correntNumber = number * -1;
while(correntNumber<=number)
{
    System.Console.Write(correntNumber);
    correntNumber= correntNumber + 1;
    System.Console.Write(correntNumber + " ");
}