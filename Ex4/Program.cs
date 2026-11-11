int numero;
int i1;
bool Eprimo;

Console.WriteLine("informe um numero: ");
numero = int.Parse(Console.ReadLine());

for(int i = 2; i <= numero; i++)
{
    Eprimo = false;

    for(i1 = 2; i1 <= i; i1++)
    {
        if(i % i1 == 0 && i != i1)
        {
            Eprimo = true;
        }
    }

    if (!Eprimo)
    {
        Console.WriteLine(i);
    }
   
}