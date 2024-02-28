using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Carro : Veiculo
    {
        private string modelo;
        private string motorista;

        // Construtor
        public Carro(string tipo, string modelo, string fabricante, int capacidade) : base(tipo, modelo, fabricante, capacidade)
        {
            this.modelo = modelo;
        }

        // Método para embarcar passageiros no carro
        public void EmbarcarPassageiro(int passageirosParaEmbarcar, string nomeMotorista)
        {
            if (passageirosParaEmbarcar <= QuantidadeAssentosDisponiveis())
            {
                //EmbarcarPassageiros(passageirosParaEmbarcar);
                motorista = nomeMotorista;
                Console.WriteLine(passageirosParaEmbarcar + " passageiro(s) embarcado(s) com sucesso.");
            }
            else
            {
                Console.WriteLine("Não há assentos suficientes disponíveis para embarcar todos esses passageiros.");
            }
        }

        // Método para informar que o carro está dirigindo
        public void Dirigir()
        {
            Console.WriteLine("Modelo do carro: " + modelo);
            Console.WriteLine("Motorista: " + motorista);
            Console.WriteLine("Quantidade de passageiros a bordo: " + QuantidadePassageirosAbordo());
        }
    }
}
