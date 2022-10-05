// программа, в которой пользователь задает длину массива, 
// элементы которого задаются в диапазоне [1,99] и выводит на экран .
Console.WriteLine("введите длинну массива: ");
int userM = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[userM];
int count = 0;
while (count < userM)
{
    mas[count] = new Random().Next(1, 100);
    count ++;
}
int count2 = 0;
Console.Write("[");
while (count2 <= count-1)
{
    Console.Write(mas[count2]);
    if (count2 < count-1)
    {
        Console.Write(",");
    }
    count2++;
}
Console.WriteLine("]");