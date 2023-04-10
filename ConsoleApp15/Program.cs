using System.Runtime.CompilerServices;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamento i = new Estacionamento();

            Console.WriteLine("Bem vindo ao sistema de estacionamento!");
            Console.WriteLine("Clique em alguma tecla para acessar nosso sistema.");
            Console.ReadLine();

            bool menu = true;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Remover Veículo");
                Console.WriteLine("3 - Listar Veículo");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine()) 
                {
                    case "1":
                        i.AdicionarVeiculos();
                        break;

                    case "2":
                        i.RemoverVeiculo();
                        break;

                    case "3":
                        i.ListarVeiculos();
                        break;

                    case "4":
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Opção não encontrada");
                        break;

                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

        }
    }
}