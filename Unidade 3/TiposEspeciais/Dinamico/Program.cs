// A variavel dinamica atribui o tipo da varável de acordo com o seu valor

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType}, Valor: {variavelDinamica}");

variavelDinamica = "Ola";

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType}, Valor: {variavelDinamica}");

variavelDinamica = true;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType}, Valor: {variavelDinamica}");
