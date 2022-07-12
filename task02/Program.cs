// <> dva chisla

int a, b;
Console.WriteLine("Введите два числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
 
if (a > b)
 {
 Console.WriteLine("{0} - бOльшее число", a);
 }
else
 {
 Console.WriteLine("{0} - бOльшее число ", b);
 }
 
Console.ReadLine();

if (a < b)
{
Console.WriteLine("{0} - меньшее число", a);
}
else
{
Console.WriteLine("{0} - меньшее число ", b);
}

Console.ReadLine();