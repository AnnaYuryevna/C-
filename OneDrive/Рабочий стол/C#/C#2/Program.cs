//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
int numberA=5;
int numberB=7;
int max = numberA;
if (numberA>max) max = numberA;
if (numberB>max) max = numberB;

Console.Write("max =  ");
Console.WriteLine(max);