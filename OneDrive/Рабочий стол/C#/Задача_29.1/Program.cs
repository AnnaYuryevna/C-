//Программа, которая задаёт массив из 8 элементов 
//и выводит их на экран 

Console.WriteLine("Введите массив, из 8 чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [8];
for (int i =0; i < array.Length; i ++)
array [i] = Convert.ToInt32(Console.ReadLine());
Console.Write ("[",  string.Join(" , ", array), "]");
