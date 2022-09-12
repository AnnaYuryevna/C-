//Программа, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
for ( int index = 1; index <= n; index ++)
Console.WriteLine (index + "^3 =" + index * index * index);