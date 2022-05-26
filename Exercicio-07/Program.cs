// See https://aka.ms/new-console-template for more information

int numero = 0;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 0)
{
    Console.WriteLine("Este número é POSITIVO!");
}
else
{
    Console.WriteLine("Este número é NEGATIVO!");
}