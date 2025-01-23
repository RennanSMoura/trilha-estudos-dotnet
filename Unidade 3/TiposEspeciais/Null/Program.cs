// É possível atribuir o valor NULL para uma variável booleana ao colocar um ? ao final da declaraçãodo tipo da variável

bool? desejaReceberEmail = null;

if(desejaReceberEmail.HasValue || desejaReceberEmail != null && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber email");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não responder");
}