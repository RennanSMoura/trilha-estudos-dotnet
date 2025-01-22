Exercício 2: Crie um dicionário para armazenar nomes de produtos e seus preços. Adicione pelo menos 5 produtos e exiba o produto com o maior preço.


Dictionary<string, decimal> catalagoProdutos = new Dictionary<string,decimal>();

catalagoProdutos.Add("Halls", 2.00M);
catalagoProdutos.Add("Suflair", 5.00M);
catalagoProdutos.Add("H20H", 6.00M);
catalagoProdutos.Add("Coca-Cola", 11.00M);
catalagoProdutos.Add("Trident", 3.00M);

string produtoMaisCaro = "";
decimal precoMaisCaro = decimal.MinValue;

foreach(KeyValuePair<string,decimal> item in catalagoProdutos)
{
    if(item.Value > precoMaisCaro ){
        produtoMaisCaro = item.Key;
        precoMaisCaro = item.Value;
    }
}

Console.WriteLine($"O produto mais caro é: {produtoMaisCaro} com o valor de {precoMaisCaro:C}.");