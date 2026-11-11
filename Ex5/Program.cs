int numero;

Console.WriteLine("informe um numero: ");
numero = int.Parse(Console.ReadLine());

int resultado = numero;

if (numero == 0)
{
    Console.WriteLine(1);
}
else
{
    for (int i = numero - 1; i > 1; i--)
    {
        resultado *= i;
        Console.WriteLine(resultado);
    }
}