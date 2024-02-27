using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_Objetos_C_
{
    class Elevador
    {
        public int andarAtual {  get; set; }
        public int totalAndares { get; set; }
        public int capacidade { get; set; }
        public int qtdPessoas { get; set; }

        public Elevador(int andarAtual, int totalAndares, int capacidade, int qtdPessoas)
        {
            this.andarAtual = andarAtual;
            this.totalAndares = totalAndares;
            this.capacidade = capacidade;
            this.qtdPessoas = qtdPessoas;
        }

        public void Inicializar()
        {
            Console.WriteLine("Digite a capacidade do elevador: " );
            int opcao1 = Convert.ToInt32(Console.ReadLine());
            capacidade += opcao1;
            Console.WriteLine("Digite o total de andares do prédio: ");
            int opcao2 = Convert.ToInt32(Console.ReadLine());
            totalAndares += opcao2;

            Console.WriteLine($"Voce está no {andarAtual}º andar \n" +
                $"Total de andares: {totalAndares}\n" +
                $"Capacidade do elevador: {capacidade}\n" +
                $"Quantidade de pessoas presentes no elevador: {qtdPessoas}");
        }

        public void entrar()
        {
            if (qtdPessoas < capacidade) 
            {
                qtdPessoas++;
                Console.WriteLine("A pessoa entrou no elevador ");
            }
            else
            {
                Console.WriteLine("O elevador está cheio");
            }
        }

        public void sair()
        {
            if (qtdPessoas > 0)
            {
                qtdPessoas--;
                Console.WriteLine("A pessoa saiu do elevador ");
            }
            else
            {
                Console.WriteLine("O elevador está vazio");
            }
        }

        public void subir()
        {
            if (andarAtual == totalAndares)
            {
                Console.WriteLine("O elevador está no andar máximo!");

            } else
            {
                andarAtual++;
                Console.WriteLine($"O elevador subiu um andar e está no:{andarAtual}º andar");
            }
        }

        public void descer()
        {
            if (andarAtual == 0)
            {
                Console.WriteLine("O elevado está no terréo");

            }
            else
            {
                andarAtual--;
                if (andarAtual == 0)
                {
                    Console.WriteLine($"O elevador desceu um andar e está no terréo");
                }
                else 
                {
                    Console.WriteLine($"O elevador desceu um andar e está no:{andarAtual}º andar");
                }
                
            }
        }
    }

}
