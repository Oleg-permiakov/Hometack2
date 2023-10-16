// Какое из чисел больше, а какое меньше
Console.WriteLine("Введите первое число");
string namber1 = Console.ReadLine();
int a = Convert.ToInt32(namber1);
Console.WriteLine("Введите второе число");
string namber2 = Console.ReadLine();
int b = Convert.ToInt32(namber2);
if (a > b)
{
    Console.WriteLine(a + " Больше чем " + b);
}    
if (b > a)
{
    Console.WriteLine(b + " Больше чем " + a);
}    