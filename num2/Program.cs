Console.Clear();
//Первое решение задачи
int number = new Random(). Next(100, 1000);
int num1 = number / 100;
int num3 = number % 10;
Console.WriteLine(number);
Console.WriteLine($"{num1}{num3}");

//Второе решение задачи
int number1 = new Random(). Next(100, 1000);
Console.WriteLine(number);
int num1_1 = number / 100;
int num3_1 = number % 10;
int IscNum = num1 * 10 + num3;
System.Console.WriteLine(IscNum);