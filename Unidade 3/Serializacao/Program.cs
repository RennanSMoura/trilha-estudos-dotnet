//SERIALIZACAO
//Serialização é o processo que consiste em transformar objetos em um fluxo de bytes para seu armazenamento ou transmissão
// Ao instanciar um objeto ele só funcionará dentro do projeto atual, mas caso queira utilizar esse mesmo objeto em outro projeto é necessário fazer a chamada serialização
// Objeto do tipo pessoa - posso serializar ele para um BD, Memória ou Arquivo, para isso ele é transformado em um fluxo de Bytes;
// O processo de deserialização é o processo inverso, transformando um arquivo por exemplo em algum objeto

//JSON

// FORMATO

// {
//     "Id" : 1,
//     "Produto": "P1",
//     "Peco": 10.50
// }

// O JSON é utilizado para serializar objetos para o compartilhamento entre diferentes linguagens ou dentro do seu próprio sistema

using Serializacao;

// Quem ira fazer a serialização será a biblioteca Newtonsoft.Json;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1,"Material de escritório", 25.00M, dataAtual);
Venda v1 = new Venda(2,"Licenca de software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

// Serializa apenas um objeto
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

// Serializa a lista de objetos
string listaSerializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

Console.Writeline(serializado);
// A saída esperada será um string no formato Json;

// {
//     "Id" : 1,
//     "Produto": "Material de escritório",
//     "Peco": 25.00
// }

File.WriteAllText("Serializacao/vendas.json", serializado);
// Ao executar o programa será criado um arquivo Json


File.WriteAllText("Serializacao/vendas.json", listaSerializada);


// Saída esperada
//[
// {
//     "Id" : 1,
//     "Produto": "Material de escritório",
//     "Peco": 25.00
// },

//  {
//     "Id" : 2,
//     "Produto": "Licença de Software",
//     "Peco": 110.00
//  }
//]