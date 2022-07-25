// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int exponent (int numA, int numB)
{
int result=numA;
int count=1;
while (count<numB)
    {
        result = result*numA;
        count++;
    }
return (result);
} 

Console.WriteLine("введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (exponent(A,B));