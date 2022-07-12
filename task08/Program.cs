// chetniye chisla ot 1 do N

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int vrem = 1;
while (vrem <= N)
{
    if (vrem % 2 == 0)
    {
        Console.Write(vrem + " ");
    }
    vrem++;
}