using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Exercício 1: Crie uma classe Carro com os seguintes atributos: marca, modelo e ano. Implemente um construtor que inicialize esses atributos. Crie um objeto Carro e exiba seus detalhes no console.


namespace Unidade2.EXERCICIOS.Ex 01 - Construtor
{
    public class Carro
    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}
        public Carro(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }

    }
}