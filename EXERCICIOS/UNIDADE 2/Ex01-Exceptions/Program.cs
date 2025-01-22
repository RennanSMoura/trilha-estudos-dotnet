// Exercício 1: Crie uma função que divida dois  inteiros e trate a exceção DivideByZeroException. Exiba uma mensagem apropriada no console quando a exceção for capturada.

try
{

Console.WriteLine("Digite o dividendo: ");
int dividendo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o divisor: ");
int divisor = int.Parse(Console.ReadLine());

int resultado = dividendo / divisor
Console.WriteLine($"O resultado da divisão é: {resultado}")

}catch(DivideByZeroException)
{
    Console.WriteLine("Não é possível dividir um número por 0");
}


