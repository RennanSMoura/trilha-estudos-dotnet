namespace ExemploExplorando.Models;
{
    public class ExemploExecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            } catch (Exception ex)
             {
                Console.WriteLine("Exceção tratada");
             }
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {
            // O Throw joga a exceção para cima buscando alguem para tratar ela, de forma que 
            throw new Exception("Ocorreu uma excecao");
        }
    }
}
