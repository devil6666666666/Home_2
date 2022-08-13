// Выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int module = Math.Abs(number);
string str = Convert.ToString(module);
char[] ar = str.ToCharArray();
int length = ar.Length;
if (length > 2)
{
    Console.WriteLine(ar[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

