using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Aviao : Veiculo
    {
        // Construtor
        public Aviao(string tipo, string modelo, string fabricante, int capacidade) : base(tipo, modelo, fabricante, capacidade)
        {
            // O construtor da classe base (Veiculo) é chamado com os parâmetros fornecidos
        }

        // Método para informar que o avião está decolando e a quantidade de passageiros
        public void Decolar()
        {
            Console.WriteLine("O avião está decolando.");
            Console.WriteLine("Quantidade de passageiros a bordo: " + QuantidadePassageirosAbordo());
        }
    }
}
