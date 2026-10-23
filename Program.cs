//вариант 13 базовый уровень
try
{
    Random rnd = new Random();
    int[] mas = new int[15];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(-10, 11);
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
    int max = mas[0];
    int min = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] > max) max = mas[i];
        if (mas[i] < min) min = mas[i];
    }
    Console.WriteLine($"max= {max} , min= {min} , s = {max+min} , r = {max-min}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}