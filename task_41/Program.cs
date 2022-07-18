Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++)
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        {
            count++;
        }
}
Console.WriteLine($"Кол-во чисел > 0: {count}");