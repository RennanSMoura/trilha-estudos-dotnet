//   using System;

//   class Program
//   {
//       static void Main(string[] args)
//       {
//           Console.WriteLine("Conversões Simples com Possíveis Erros");

//            Conversão direta de string para int (Formato Inválido)
//           string poderInvalido = "Cem"; 
//           int nivelPoder = int.Parse(poderInvalido);  Erro: string não numérica

//            Conversão direta de string para int (Valor fora do intervalo)
//           string valorGrande = "9999999999999999999999999999"; 
//           int valorInt = int.Parse(valorGrande);  Erro: valor muito grande para int

//            Conversão explícita de double para int (Perda de Dados ou Overflow)
//           double velocidadeExagerada = 1.5E+308; 
//           int velocidadeConvertida = (int)velocidadeExagerada;  Pode gerar comportamento inesperado ou erro

//            Conversão de string para bool (Formato Inválido)
//           string invisibilidade = "Sim"; 
//           bool estadoInvisibilidade = bool.Parse(invisibilidade);  Erro: string inválida para bool

//            Conversão inválida entre tipos incompatíveis
//           object heroi = "Superman"; 
//           int identidadeSecreta = (int)heroi;  Erro: tipos incompatíveis

//            Divisão por zero ao converter
//           int energiaHeroi = 100;
//           int divisaoPorZero = 0;
//           int resultado = energiaHeroi / divisaoPorZero;  Erro: divisão por zero
//       }
//   }


 using System;

 class Program
 {
     static void Main(string[] args)
     {
         Console.WriteLine("Conversões Básicas - Temática de Super-Heróis");

         //Conversão Implícita
         int forcaBase = 80;  Força de um super-herói (base)
         double forcaAvancada = forcaBase;  //Converte int para double (implícito)
         Console.WriteLine($"Força Base: {forcaBase} - Força Avançada (double): {forcaAvancada}");

         // Conversão Explícita (Cast)
         double velocidadeLuz = 299792.458;  //Velocidade da luz em km/s
         int velocidadeAproximada = (int)velocidadeLuz;  //Converte double para int
         Console.WriteLine($"Velocidade da Luz: {velocidadeLuz} km/s - Velocidade Aproximada: {velocidadeAproximada} km/s");

          //arse de String para Int
         string poder = "100";
         int nivelPoder = int.Parse(poder);  //Converte string para int
         Console.WriteLine($"Nível de Poder (string): {poder} - Nível de Poder (int): {nivelPoder}");

         // TryParse
         string energia = "500";
         if (int.TryParse(energia, out int nivelEnergia))
         {
             Console.WriteLine($"Energia (string): {energia} - Energia (int): {nivelEnergia}");
         }
         else
         {
             Console.WriteLine("Erro ao converter a energia.");
         }

         // Conversão com Convert
         bool invisibilidade = true;  //Habilidade de invisibilidade
         int invisibilidadeValor = Convert.ToInt32(invisibilidade);//  Converte bool para int
         Console.WriteLine($"Invisibilidade: {invisibilidade} - Valor Numérico: {invisibilidadeValor}");

          //De Int para String
         int numeroAliados = 7;
         string aliadosString = numeroAliados.ToString();  Converte int para string
         Console.WriteLine($"Número de Aliados (int): {numeroAliados} - Número de Aliados (string): {aliadosString}");

          //Conversão de Char para Int
         char codigoHeroi = 'H'; // Código do herói
         int valorUnicode = (int)codigoHeroi;  //Converte char para seu valor Unicode (int)
         Console.WriteLine($"Código do Herói: {codigoHeroi} - Valor Unicode: {valorUnicode}");

          //Conversão de Int para Char
         int numeroCoringa = 74; // Representação numérica de um personagem
         char simboloCoringa = (char)numeroCoringa; // Converte int para char
         Console.WriteLine($"Número do Coringa (int): {numeroCoringa} - Símbolo do Coringa (char): {simboloCoringa}");

          //Conversão de Float para Decimal
         float alturaHeroi = 1.85f;
         decimal alturaPrecisao = (decimal)alturaHeroi; // Conversão explícita
         Console.WriteLine($"Altura do Herói (float): {alturaHeroi}m - Altura com Precisão (decimal): {alturaPrecisao}m");

          // Conversão de Byte para String
         byte nivelEscudo = 255; // Máximo valor de um byte
         string escudoString = nivelEscudo.ToString();  //Converte byte para string
         Console.WriteLine($"Nível do Escudo (byte): {nivelEscudo} - Nível do Escudo (string): {escudoString}");
     }
 }
