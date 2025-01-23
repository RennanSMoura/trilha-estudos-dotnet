using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; // Importacao da biblioteca

namespace Unidade 3.Serializacao
{
    public class VendaDeserelializacao
    {

        public int Id { get; set; }

        // A classe JsonProperty é uma classe que está utilizando um atributo 
        // No caso atual, estamos simulando que meu JSON está vindo com um campo com sua nomeclatura fora de convenção, ao utilizar esta classe e passando como atributo o nome originário do JSON, ele será revertido corretamente para o padrão utilizado no código
        // a sintaxe acima de uma propriedade ou de uma classe é tida como um atributo "[]", onde está dizendo que poderá fazer alguma representação daquela classe ou propriedade ou algum comportamento diferente
        
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public decimal? Desconto { get; set; }
        public DateTime DataVenda { get; set; }

    }
}

// Para que a deserialização seja bem feita é necessário que as propriedades tenham o mesmo nome dos Campos do arquivo JSON