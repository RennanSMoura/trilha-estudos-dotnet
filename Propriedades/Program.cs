// Classe Pessoa com encapsulamento e uso de propriedades


// Código no Program.cs
using System;
using System.Collections.Generic;
using Propriedades;

// Criando objetos Pessoa
Pessoa p1 = new Pessoa(nome: "Rennan", sobrenome: "Moura");
p1.Idade = 20;

Pessoa p2 = new Pessoa { Nome = "Leticia", Sobrenome = "Redondo", Idade = 25 };

// Criando objeto Curso e adicionando alunos
Curso cursoDeIngles = new Curso { Nome = "Inglês" };
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

// Listando alunos do curso
cursoDeIngles.ListarAlunos();
