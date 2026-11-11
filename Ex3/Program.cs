int numero;


Console.WriteLine("informe um numero: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("impares: ");
for(int i = 0; i <= numero; i++)
{
    if(i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

Thread.Sleep(2000);

Console.WriteLine("pares: ");
for(int i = numero; i >= 0; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

