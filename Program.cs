// Mystic Elf

String mensagemBoasVindas = "Boas Vindas ao Mystic Elf";

void ExibirMensagemBoasVindas()
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
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas ás bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opçãoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opçãoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida + ". A banda foi registrada com sucesso.");
            break;
        case 2: Console.WriteLine("\nVocê escolheu a opção: " + opcaoEscolhida + ".\n Iron Maiden.\n Nirvana.\n Disturbed.");
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
    
 /*   if (opçãoEscolhidaNumerica == 1)
    {
        Console.WriteLine("Você escolheu a opção: " + opcaoEscolhida + ". A banda foi registrada com sucesso.");
    } else if (opçãoEscolhidaNumerica == 2)
    {
        Console.WriteLine("\nVocê escolheu a opção: " + opcaoEscolhida + ".\n Iron Maiden.\n Nirvana.\n Disturbed.");
    }
*/ 
}
ExibirMensagemBoasVindas();
ExibirOpcoesMenu();