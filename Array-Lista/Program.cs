// // Declaração de arrays
// int[] array = new int[4];                        // Array de inteiros com 4 posições
// int[] arrayInicializado = new int[] {10, 20, 30, 40}; // Array inicializado com valores
// string[] nomes = {"Jan", "Fev"};                 // Array de strings inicializado com valores
// int[] arrayInteiros = new int[3];                // Array de inteiros com 3 posições

// // Atribuição de valores ao array
// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = 30;

// // Iteração com 'for'
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Número {contador} - {arrayInteiros[contador]}");
// }

// // Iteração com 'foreach'
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// // Redimensionamento de um array
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Duplica o tamanho do array

// // Copiando um array
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2]; // Cria um novo array com o dobro do tamanho
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length); // Copia os valores do array original para o novo array


// Declaração de uma lista de strings
List<string> listaString = new List<string>();

// Adicionando elementos à lista
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

// Iteração com 'for'
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N°{contador} - {listaString[contador]}");
}

// Iteração com 'foreach'
int contador = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N°{contador} - {item}");
    contador++;
}

// Exibindo a capacidade e o tamanho da lista
Console.WriteLine($"Capacidade da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Adicionando mais um elemento à lista
listaString.Add("SC");

// Observação: 
// Ao fazer o uso de uma lista e adicionar mais um elemento, ela se auto-redimensiona automaticamente,
// não sendo necessário fazer o uso do .Resize().
