Console.Write("Введите первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2) { Console.Write("Число " + num1 + " больше"); }
if (num1 < num2) { Console.Write("Число " + num2 + " больше"); }
if (num1 == num2) { Console.Write("Числa равны"); }