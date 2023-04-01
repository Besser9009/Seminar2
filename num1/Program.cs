Console.Clear();
Console.WriteLine("Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую переменную в этом числе.");
Console.WriteLine("Например: 78 -> 8");
int number = new Random(). Next(10, 100);
int num1 = number / 10;
int num2 = number % 10;
Console.WriteLine(number);
if (num1 > num2){
    Console.WriteLine($"num1 > num2; max == {num1}");
}
else if (num1 < num2){
    Console.WriteLine($"num2 > num1; max == {num2}");
}
else{
    Console.WriteLine($"num2 == num1; max == {num1}");
}