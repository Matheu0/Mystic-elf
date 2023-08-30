// Mystic Elf

String mensagemBoasVindas = "Boas Vindas ao Mystic Elf";
List<string> listaDeBandas = new List<string> { "Iron Maiden", "Black Sabbath", "AC/DC", "Pink Floyd", "Linkin Park"};

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
    Console.WriteLine("Digite 2 para mostrar todas ás bandas.");
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
        case 3: Console.WriteLine("\nVocê escolheu a opção: " + opcaoEscolhida);
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
        listaDeBandas.Add(nomeDaBanda);
        Console.WriteLine($"A banda foi *{nomeDaBanda}* registrada com sucesso.");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoesMenu();
    }

    void MostrarBandasRegistradas()
    {
        Console.Clear();
        Console.WriteLine("Exibição das Bandas Registradas:\n");
        for (int i = 0; i < listaDeBandas.Count; i++) 
        {
            Console.WriteLine($"Banda: *{listaDeBandas[i]}*");
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
}
ExibirOpcoesMenu();