string conteudoArquivo = File.ReadAllText("Serializacao/venda.json")

List<VendaDeserializacao> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

Console.WriteLine(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} - Preço: {venda.Preco}, Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, Desconto: {venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : Produto sem desconto}");
}