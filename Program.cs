// Mystic Elf

String mensagemBoasVindas = "Seja Bem-Vindo ao Mystic Elf";
//List<string> listaDeBandas = new List<string> { "Iron Maiden", "Black Sabbath", "AC/DC", "Pink Floyd", "Linkin Park"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("Iron Maiden", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗░██████╗████████╗██╗░█████╗░  ███████╗██╗░░░░░███████╗
████╗░████║╚██╗░██╔╝██╔════╝╚══██╔══╝██║██╔══██╗  ██╔════╝██║░░░░░██╔════╝
██╔████╔██║░╚████╔╝░╚█████╗░░░░██║░░░██║██║░░╚═╝  █████╗░░██║░░░░░█████╗░░
██║╚██╔╝██║░░╚██╔╝░░░╚═══██╗░░░██║░░░██║██║░░██╗  ██╔══╝░░██║░░░░░██╔══╝░░
██║░╚═╝░██║░░░██║░░░██████╔╝░░░██║░░░██║╚█████╔╝  ███████╗███████╗██║░░░░░
╚═╝░░░░░╚═╝░░░╚═╝░░░╚═════╝░░░░╚═╝░░░╚═╝░╚════╝░  ╚══════╝╚══════╝╚═╝░░░░░

");

    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite 0 para sair.");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opçãoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opçãoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: Console.WriteLine("\nVocê escolheu a opção: " + opcaoEscolhida);
            break;
        case 0: Console.WriteLine("\n Bye Bye marujo :) ");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
    }
    void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("Registro de Bandas");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda foi *{nomeDaBanda}* registrada com sucesso.");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoesMenu();
    }

    void MostrarBandasRegistradas()
    {
        Console.Clear();
        Console.WriteLine("Exibição das Bandas Registradas:\n");

        /*for (int i = 0; i < listaDeBandas.Count; i++) 
        {
            Console.WriteLine($"Banda: *{listaDeBandas[i]}*");
        }
        */

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: *{banda}*");
        }

        Console.WriteLine("\nPressione alguma tecla para voltar ao menu inicial!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }

    /*   if (opçãoEscolhidaNumerica == 1)
       {
           Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida + ". A banda foi registrada com sucesso.");
       } else if (opçãoEscolhidaNumerica == 2)
       {
           Console.WriteLine("\nVocê escolheu a opção: " + opcaoEscolhida + ".\n Iron Maiden.\n Nirvana.\n Disturbed.");
       }
   */

    void AvaliarBanda()
    {
        Console.Clear();
        Console.WriteLine("Avaliar Bandas: \n");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
         if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.WriteLine();
        }else 
        {
            Console.WriteLine($"\nA banda *{nomeDaBanda}* não foi encontrada");
            Console.WriteLine("\nPressione alguma tecla para voltar ao menu inicial!");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }

    }
}
ExibirOpcoesMenu();