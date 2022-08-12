// Показывает вторую цифру трёхзначного числа

beginning:
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) > 99 && Math.Abs(number) < 1000)
{
    Console.Write(Math.Abs((number%100 - number%10)/10));
}
else
{
    goto beginning;
}

