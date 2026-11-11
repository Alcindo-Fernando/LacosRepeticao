int numero;
int i;
int atual = 0;
int anterior = 1;
int proximo;

Console.WriteLine("digite um numero: ");
numero = int.Parse(Console.ReadLine());

for (i = 1; atual <= numero; i++)
{
    Console.WriteLine(atual);

    proximo = anterior + atual;
    anterior = atual;
    atual = proximo;
   

}
