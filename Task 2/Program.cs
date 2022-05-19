/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
string GetNumber()
{
    return Console.ReadLine();
}
int CountNum(string str)                   
{
                                           // int num = int.Parse(str);
                                           // int count = 0;
                                           // while(num>0)
  return str.Length;                       // {
                                           // num = num / 10;
                                           // count++    
                                           // }
}                                          //return count     
Console.WriteLine("Введите число");
int countNum = CountNum(GetNumber());
Console.WriteLine(countNum);
