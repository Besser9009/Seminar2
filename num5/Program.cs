Console.Clear();
System.Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 * num1 == num2){
    System.Console.WriteLine("Да второе число является квадратом первого");
}
else{
    System.Console.WriteLine("Нет второе число не является квадратом первого");
}
