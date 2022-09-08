// Программа, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<99)
    Console.WriteLine("Третьей цыфры нет");
else
    Console.Write(Convert.ToString(n)[2]);
