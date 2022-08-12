// Показывает вторую цифру трёхзначного числа

beginning:
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) > 99 && Math.Abs(number) < 1000)
{
   string str = Convert.ToString(Math.Abs(number));
   char [] ar = str.ToCharArray();
   Console.WriteLine(ar[1]);

}
else
{
    goto beginning;
}
