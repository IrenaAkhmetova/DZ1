Console.Write("Input firts number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"Maximum number: {a} Minimal number: {b}");
}
else
{
Console.WriteLine($"Maximum number: {b} Minimal number: {a}");
}