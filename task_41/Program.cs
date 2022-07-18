Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] matrix = new int[m];
int count = 0;
for (int i = 0; i < m; i++)
{
    if (matrix[i] > 0)
        {
            count++;
        }
}
Console.WriteLine($"Кол-во чисел > 0: {count}");
