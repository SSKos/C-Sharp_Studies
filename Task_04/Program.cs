Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
int even = num % 2;
if (even == 0) { 
Console.Write("Число " + num + " четное"); }
else {
Console.Write("Число " + num + " нечетное");
}