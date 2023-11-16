// See https://aka.ms/new-console-template for more information


Console.Write("Введите кол-во элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
int number = 0;
for (int i = 1; i <= m; i++)
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во положительных элементов равно {count}");


