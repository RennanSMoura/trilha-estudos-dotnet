using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidade 2.EXERCICIOS.Ex 03 - Construtores
{
    public class Livro
    {
        public string Titulo {get; set;}
        public string Autor {get; set;}
        public int AnoPublicacao {get; set;}

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoPublicacao = anoPublicacao;
        }

    }
}