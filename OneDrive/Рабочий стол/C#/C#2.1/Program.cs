//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
int numberA=2;
int numberB=10;
int max = numberA;
if (numberA>max) max = numberA;
if (numberB>max) max = numberB;

Console.Write("max =  ");
Console.WriteLine(max);