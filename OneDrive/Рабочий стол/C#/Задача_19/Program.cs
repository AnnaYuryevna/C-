//Программа, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом

Console.Clear();
Console.WriteLine("Введите n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n3");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n4: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n5: ");
int n5 = Convert.ToInt32(Console.ReadLine());

if (n1 == n5 && n2 == n4)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
