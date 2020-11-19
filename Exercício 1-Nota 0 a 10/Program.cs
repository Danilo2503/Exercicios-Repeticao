using System;

namespace Exercício_1_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota:");
            int nota = int.Parse(Console.ReadLine());
            
            while(nota <=0 || nota>10 ){
                Console.WriteLine("Valor inválido");
                Console.WriteLine("Digite um valor de 0 a 10");
                nota = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito obrigado pelo seu tempo!");

        }
    }
}
