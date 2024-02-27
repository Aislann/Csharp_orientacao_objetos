using Orientação_Objetos_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o andar atual: ");
        int andar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de pessoas presentes no elevador: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());


        // Exemplo de uso
        Elevador elevador = new Elevador(andar, 0, 0, quantidade);

        elevador.Inicializar();

        int i = 0;
        while (i < 1)
        {
            Console.WriteLine("\n" +
                "1- Entrar\n" +
                "2- Sair\n" +
                "3- Subir\n" +
                "4- Descer\n" +
                "Escolha o que deseja fazer: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                elevador.entrar();
            } else if (opcao == 2)
            {
                elevador.sair();
                i++;
                break;
            } else if(opcao == 3)
            {
                elevador.subir();   
            } else if (opcao == 4)
            {
                elevador.descer();
            }
            
        }
    }
}