// Exercício 2: Crie uma pilha (Stack) para armazenar ações de desfazer em um editor de texto. Adicione pelo menos 3 ações à pilha e remova e exiba a última ação a ser desfeita.

Stack<string> acoesEditorTexto = new Stack<string>();

acoesEditorTexto.Push("Remover usuários");
acoesEditorTexto.Push("Remover Cargo");
acoesEditorTexto.Push("Adicionar Cadastro");

while(acoesEditorTexto.Count>0)
{
    Console.WriteLine(acoesEditorTexto.Pop());
}
