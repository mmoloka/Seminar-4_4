/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/
bool IsNumberPositive(int number)
{
    return number > 0;
}
int GetSumFromOneToNumber(int number)
{
    int sum = 0;
    for(int i = 1;i <= number;i++)
    sum += i;    //sum = sum + i
    return sum;
}

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if(IsNumberPositive(number))
{
    int sum = GetSumFromOneToNumber(number);
    Console.WriteLine($"Сумма чисел от 1 до n: {sum}");
}
else
{
    Console.WriteLine("Некорректное число");
}
