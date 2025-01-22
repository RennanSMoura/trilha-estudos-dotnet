using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidade 2.EXERCICIOS.Ex 03 - Construtores
{
    public class Biblioteca
    {

        private List<Livro> Livros; 
        public Biblioteca() 
        { 
            Livros = new List<Livro>(); 
        }
        
        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void ExibirLivros(){
            foreach(var livro in Livros)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoPublicacao}");
            }
        }
    }
}