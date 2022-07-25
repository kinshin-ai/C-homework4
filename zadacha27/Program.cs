// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int digitSum (int number)
{
    int digit=1;
    while (number/digit>10)
    {
        digit=digit*10;
    }
    int sum = 0;
    int counter = 1;
    while (digit>0)
    {
        sum = sum+number/(digit*counter);
        number = number-digit*(number/digit);
        digit = digit/10;
    }
    return (sum);
}
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(digitSum(num));