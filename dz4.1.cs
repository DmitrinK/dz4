// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int count = 2;
int sum = numA;
if (numB == 0)
{
    Console.WriteLine ("1");
    return;
}
if (numB == 1)
{
    Console.WriteLine ($"{numA}");
    return;
}
while (count <= numB)
{
    sum = sum*numA;
    count++;
}
Console.WriteLine ($"{sum}");