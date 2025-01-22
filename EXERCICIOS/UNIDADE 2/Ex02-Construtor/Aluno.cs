using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidade 2.EXERCICIOS.Ex 02 - Construtor
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Curso {get; set;}

        public Aluno(string nome, int idade, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Curso = curso;
        }
        public void ExibirDetalhes() 
        { 
            Console.WriteLine($"O aluno {this.Nome} tem {this.Idade} anos e está matriculado no curso de {this.Curso}.")
        }
    }
}