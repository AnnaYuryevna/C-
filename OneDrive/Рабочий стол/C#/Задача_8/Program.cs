// Программа, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int index = 2; index <= N; index += 2)
    Console.Write(index + " ");
