// Classe Curso para gerenciar alunos

namespace Propriedades{


public class Curso
{
    // Propriedades com getters e setters automáticos
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

    // Adiciona um aluno à lista
    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }

    // Retorna o total de alunos matriculados
    public int ObterQuantidadeAlunosMatriculados()
    {
        return Alunos.Count;
    }

    // Remove um aluno da lista
    public void RemoverAluno(Pessoa aluno)
    {
        Alunos.Remove(aluno);
    }

    // Lista os alunos matriculados
    public void ListarAlunos()
    {
        for (int count = 0; count < Alunos.Count; count++) // Corrigido para iniciar em 0
        {
            string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
            Console.WriteLine(texto);
        }
    }
}
}