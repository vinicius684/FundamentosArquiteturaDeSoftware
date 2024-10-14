 using System;

namespace SOLID.LSP.Violacao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static  void Calcular()
        {
            var quad = new Quadrado()//quadrado modifica o comportamento da Superclasse retangulo, portanto se recebido como um retangulo vai dar erro
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}