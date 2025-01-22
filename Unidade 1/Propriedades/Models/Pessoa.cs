public class Pessoa
{
    // <Construtores>
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    // public Pessoa() { }
    // Um construtor vazio permite criar objetos sem parâmetros.
    // </Construtores>

    // Campos privados para encapsular os dados
    private string _nome;
    private int _idade;

    // Propriedade para Nome com validação e formatação
    public string Nome
    {
        get => _nome.ToUpper(); // Retorna o nome em letras maiúsculas
        set
        {
            if (string.IsNullOrWhiteSpace(value)) // Validação para nome vazio ou nulo
                throw new ArgumentException("O nome não pode ser vazio");

            _nome = value;
        }
    }

    // Propriedade para Idade com validação
    public int Idade
    {
        get => _idade;
        set
        {
            if (value < 0) // Validação para idade negativa
                throw new ArgumentException("A idade não pode ser menor que 0");

            _idade = value;
        }
    }

    // Propriedade automática para Sobrenome
    public string Sobrenome { get; set; }

    // Propriedade somente leitura para NomeCompleto
    public string NomeCompleto => $"{Nome} {Sobrenome}";

    // Método para exibir uma apresentação
    public void Apresentar()
    {
        Console.WriteLine($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos.");
    }
}
