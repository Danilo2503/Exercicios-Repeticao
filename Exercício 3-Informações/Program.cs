using System;

namespace Exercício_3_Informações
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            while (nome == "")
            {
                Console.WriteLine("Nome inválido - Digite um nome não vazio");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Informe sua idade:");
            int idade = int.Parse(Console.ReadLine());
            while (idade <=0 || idade >= 150)
            {
                Console.WriteLine("Idade inválida - digite um valor entre 0 e 150");
                idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite seu salário:");
            float sal = float.Parse(Console.ReadLine());
            while (sal <= 0)
            {
                Console.WriteLine("Valor digitado inválido - digite um valor maior que 0");
                sal = float.Parse(Console.ReadLine());
            }    
        }
    }
}
