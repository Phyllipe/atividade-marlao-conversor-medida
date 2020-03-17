using System;

namespace atividade_2_marlao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor para converter");
            conversor S =new conversor(Convert.ToDouble(Console.ReadLine()));


            Console.WriteLine(S.Quilometro + " kms");
            Console.WriteLine(S.Metro + " mt");
            Console.WriteLine(S.Centimetro + " cms");
            Console.WriteLine(S.Milimetro + " mls");
            Console.WriteLine(S.Micrometro + " mcts");
            Console.WriteLine(S.Nanometro + " nnts");
            Console.WriteLine(S.Milha + " milhas");
            Console.WriteLine(S.Jarda + " jardas");
            Console.WriteLine(S.Pe + " pés");
            Console.WriteLine(S.Polegada + " plgs");
            Console.WriteLine(S.Milhanautica + " mns");




        }
    }
}
