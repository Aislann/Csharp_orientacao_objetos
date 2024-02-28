using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Veiculo
    {
        private string tipo;
        private string modelo;
        private string fabricante;
        private int capacidade;
        private int quantidadePassageirosAbordo;

        // Construtor
        public Veiculo(string tipo, string modelo, string fabricante, int capacidade)
        {
            this.tipo = tipo;
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.capacidade = capacidade;
            quantidadePassageirosAbordo = 0;
        }

        // Métodos GET
        public string Modelo()
        {
            return modelo;
        }

        public int Capacidade()
        {
            return capacidade;
        }

        public int QuantidadePassageirosAbordo()
        {
            return quantidadePassageirosAbordo;
        }

        public int QuantidadeAssentosDisponiveis()
        {
            return capacidade - quantidadePassageirosAbordo;
        }

        // Métodos SET
        public void RemoverTodosPassageiros()
        {
            quantidadePassageirosAbordo = 0;
        }

        public void EmbarcarPassageiros(int quantidadePassageirosEmbarcar)
        {
            if (quantidadePassageirosAbordo + quantidadePassageirosEmbarcar <= capacidade)
            {
                quantidadePassageirosAbordo += quantidadePassageirosEmbarcar;
                Console.WriteLine(quantidadePassageirosEmbarcar + " passageiro(s) embarcado(s) com sucesso.");
            }
            else
            {
                Console.WriteLine("Não há espaço suficiente para embarcar todos esses passageiros.");
            }
        }

        public void RemoverPassageiros(int quantidadePassageirosRemover)
        {
            if (quantidadePassageirosRemover <= quantidadePassageirosAbordo)
            {
                quantidadePassageirosAbordo -= quantidadePassageirosRemover;
                Console.WriteLine(quantidadePassageirosRemover + " passageiro(s) removido(s) com sucesso.");
            }
            else
            {
                Console.WriteLine("Não há passageiros suficientes a bordo para remover.");
            }
        }
    }

}
