Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    int even = i % 2;
    if (even == 0)
    {
        Console.Write(i + " ");
    }
}