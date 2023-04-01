Console.Clear();
//Первое решение
System.Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
if (num1 % 7 == 0){
    if (num1 % 23 == 0){
        Console.WriteLine("Да, кратно 23 и 7");
    }
    else{
        System.Console.WriteLine("Не кратно 23, но кратно 7");
    }
}
else{
    System.Console.WriteLine("Не кратно 7");
}
//Второе решение
System.Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
if (num1 % 7 == 0 && num1 % 23 == 0){
    System.Console.WriteLine("Да, кратно 23 и 7");
}
else{
    System.Console.WriteLine("Не кратно 23 и 7");
}