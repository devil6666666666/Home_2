// Принимает на вход номер дня недели и проверяет, 
// является ли он выходным

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] arr = { "нет", "да" };
if (number >= 1 && number <= 7)
{
    if (number < 6)
    {
        Console.WriteLine(arr[0]);
    }
    else
    {
        Console.WriteLine(arr[1]);
    }

}
else
{
    Console.WriteLine("Такого дня нет");
}

