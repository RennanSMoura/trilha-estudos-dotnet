using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidade 3.Tuplas
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho)

                return (true,linhas,linhas.Count());
            }
            catch(Exception)
            {
                return(false, new string[0], 0);
            }
        }
    }
}

// Neste exemplo está sendo demonstrado o uso de tuplas em métodos, pode ser útil quando queremos retornar mais de uma informação em um método. (LEMBRANDO QUE UM MÉTODO SÓ PODE TER UM RETORNO).