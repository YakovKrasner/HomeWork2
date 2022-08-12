
int findSecondDigit(int arg1)
{
     int result = (arg1 % 100) / 10;
     return result;
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine (findSecondDigit (number));