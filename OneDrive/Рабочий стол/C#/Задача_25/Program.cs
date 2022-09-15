//Напишите цикл, который принимает на вход два числа (a и b) 
//и возводит число a в натуральную степень b



Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "a^b=" + Math.Pow( a, b) );