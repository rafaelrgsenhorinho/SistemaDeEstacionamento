using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new();

        public Estacionamento (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo ()
        {
            Console.WriteLine("Digite a placa do veículo para adicionar:");
            string placa = "";
            placa = Console.ReadLine();
            if(placa != "")
            {
                veiculos.Add(placa);
            } else {
                Console.WriteLine("Placa não pode ser vazia!");
            }
        }

        public void RemoverVeiculo ()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            string placa = "";
            placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;

                horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal}");

            } else {
                Console.WriteLine("Desculpe, esse veículo não esta estacionado aqui. Confira se digitou a placa correta.");
            }


        }

        public void ListarVeiculos()
        {
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(string placa in veiculos)
                {   
                    Console.WriteLine(placa);
                }
            }
            else {
                Console.WriteLine("Não há veículos estacionados");
            }
        }
    }


}