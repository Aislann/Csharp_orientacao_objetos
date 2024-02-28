using Desafio2;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 1)
        {
            Console.WriteLine("\n" +
                "1- Veiculo\n" +
                "2- Carro\n" +
                "3- Aviao\n" +
                "0- Parar\n" +
                "Escolha o que deseja fazer: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 0)
            {
                i++;
                break;
            }
            else if(opcao == 1)
            {
                Console.Clear();
                // Instanciando objetos para a classe Veiculo (carro e aviao)
                Veiculo carro = new Veiculo("Carro", "Fiesta", "Ford", 5);
                Console.WriteLine("Veículo - Quantidade de passageiros a bordo: " + carro.QuantidadePassageirosAbordo());
                Console.WriteLine("Veículo - Assentos disponíveis: " + carro.QuantidadeAssentosDisponiveis());
                carro.EmbarcarPassageiros(3);

                Veiculo aviao = new Veiculo("Avião", "Boeing 737", "Boeing", 200);
                Console.WriteLine("Avião - Quantidade de passageiros a bordo: " + aviao.QuantidadePassageirosAbordo());
                Console.WriteLine("Avião - Assentos disponíveis: " + aviao.QuantidadeAssentosDisponiveis());
                aviao.EmbarcarPassageiros(150);
            }
            else if (opcao == 2)
            {
                Console.Clear();
                // Instanciando objetos para a classe Carro (uno e prisma)
                Carro uno = new Carro("Carro", "Uno", "Fiat", 5);
                uno.EmbarcarPassageiro(3, "João");
                uno.Dirigir();
                Console.WriteLine();

                Carro prisma = new Carro("Carro", "Prisma", "Chevrolet", 5);
                prisma.EmbarcarPassageiro(2, "Maria");
                prisma.Dirigir();
                Console.WriteLine();
            }
            else if (opcao == 3)
            {
                Console.Clear();
                // Instanciando objetos para a classe Aviao (latam e azul)
                Aviao latam = new Aviao("Avião", "Airbus A320", "Latam", 150);
                latam.EmbarcarPassageiros(100);
                latam.Decolar();
                Console.WriteLine();

                Aviao azul = new Aviao("Avião", "Embraer 190", "Azul", 100);
                azul.EmbarcarPassageiros(80);
                azul.Decolar();
            }


        }

    }
}