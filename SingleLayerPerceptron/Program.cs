using System;

namespace SingleLayerPerceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int key = 1;
            bool exit = true;
            Planeta planeta;

            while (key != 0)
            {
                planeta = new Planeta();
                while (exit)
                {
                    Console.WriteLine("Digite um comprimento de onda em nm de um elemento presente no Planeta (xxx.xx)");
                    planeta.setPresent(double.Parse(Console.ReadLine()));
                    Console.WriteLine("pressione 0 para sair, 1 para digitar um novo valor");
                    if(Console.Read() == 0)
                    {
                        exit = false;
                    }
                    Console.Clear();
                }
                




                Console.WriteLine("Pressione 0 para sair, 1 para começar novamente");
                key = Console.Read();


            }


        }
    }
}