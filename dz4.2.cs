// программа, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число: ");
int userN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (userN > 0)
{
    sum = sum + userN % 10;
    userN = userN / 10;
}
Console.WriteLine ($"{sum}");