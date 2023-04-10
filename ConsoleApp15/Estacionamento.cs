using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Estacionamento
    {
        public int PrecoInicial;
        public int PrecoHora;
        private List<string> veiculos = new List<string>();

        public void AdicionarVeiculos()
        {
            Console.WriteLine("Digite a placa do veículo para ser adicionado:");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para ser removido:");
            string removerPlaca = Console.ReadLine().ToUpper();

            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i] == removerPlaca)
                {
                    veiculos.Remove(removerPlaca);
                    Console.WriteLine(removerPlaca + " foi removido");
                } else
                {
                    Console.WriteLine("Veículo não encontrado");
                }
            }

        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Lista de veículos");
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine(veiculos[i]);
            }
        }
    }
}
