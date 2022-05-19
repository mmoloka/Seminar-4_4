/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

int GetProdOfNum (int num)
{
    int prod = 1;
    for(int i=1;i<=num;i++)
    prod*=i;
    return prod;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int prod = GetProdOfNum(num);
Console.WriteLine(prod);
