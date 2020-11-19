using System;

namespace Exercício_2_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Validação de senha");
            Console.WriteLine("------------------");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite uma senha:");
            string senha = Console.ReadLine();

            while(nome == senha){
                Console.WriteLine("Senha inválida - Digite uma diferente");
                Console.WriteLine("Digite uma senha:");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Cadastro efetuado com sucesso");
        }
    }
}
