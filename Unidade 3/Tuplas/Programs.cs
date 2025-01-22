// Tuplas - Fornece uma sintaxe concisa para agrupar vários elementos de dados em uma estrutura de dados leve.

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerAquivo("Unidade3/Tuplas/arquivoTeste.txt");
// Caso queira fazer o descarte de uma informação basta utiliza o "_" na tupla
// var (sucesso, linhasArquivo, _) = arquivo.LerAquivo("Unidade3/Tuplas/arquivoTeste.txt");

if(sucesso)
{
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}else{
    Console.WriteLine("Não foi possível ler o arquivo");
}













// // A definição de valores de uma tupla tem de ser na exata ordem da criação da Mesma
// (int, string, string, decimal) tupla = (1,"Rennan","Moura", 1.83);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"NOME: {tupla.Item2}");
// Console.WriteLine($"SOBRENOME: {tupla.Item3}");
// Console.WriteLine($"ALTURA: {tupla.Item4}");

// // outras maneira de representar uma tupla, porém não é possível nomear o objetos com os tipos de criação abaixo
// ValueTuple<int, string, string, decimal> tuplaDois = (1,"Rennan","Moura", 1.83M);
// var tuplaTres = tuplaTres.create(1,"Rennan", "Moura", 1.83M);