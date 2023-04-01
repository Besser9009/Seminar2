Console.Clear();
System.Console.WriteLine("Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно первому, то программа выводит остаток от деления.");
System.Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0){
    System.Console.WriteLine("Да, второе числократно первому");
}
else{
    System.Console.WriteLine($"Нет, второе число не кратно первому. Остаток: {num1 % num2}");
}
