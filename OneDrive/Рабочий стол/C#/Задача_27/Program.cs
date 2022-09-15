//Программа, которая принимает на вход число 
//и выдаёт сумму цифр в числе

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;
while(n != 0)
   {
    summa += n % 10;
    n /= 10;
   }
Console.WriteLine(summa);