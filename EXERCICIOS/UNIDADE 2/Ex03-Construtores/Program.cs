// Exercício 3: Biblioteca
// Crie uma classe Livro com os seguintes atributos: titulo, autor e anoPublicacao. Implemente um construtor que inicialize esses atributos.

// Crie uma classe Biblioteca que tenha uma lista de livros.
// Implemente um método AdicionarLivro que adicione um novo livro à lista de livros.
// Implemente um método ExibirLivros que exiba os detalhes de todos os livros na biblioteca.

Biblioteca biblioteca = new Biblioteca(); 
Livro novoLivro = new Livro("Rota 66", "Caco Barcellos", 2000); 
biblioteca.AdicionarLivro(novoLivro);