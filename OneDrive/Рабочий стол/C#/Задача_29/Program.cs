//Программа, которая задаёт массив
// и выводит их на экран

int n = Convert.ToInt32(Console.ReadLine());
int res = 1;
int i = 1;
while (i <= n)
{
    res = res * i; i++;
}
Console.WriteLine(res);