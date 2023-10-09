// Screen Sound


void ExibirMensagemDeBoasVindas() {
    Console.WriteLine("***********************");
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("***********************");
}


void OpcoesDoMenu(){
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcao = Console.ReadLine()!;
    int escolha = int.Parse(opcao);

    switch (escolha) {
        case 1 : Console.WriteLine("Voce escolheu a opção " + escolha); 
            break;
        case 2 : Console.WriteLine("Voce escolheu a opção " + escolha); 
            break;
        case 3 : Console.WriteLine("Voce escolheu a opção " + escolha); 
            break;
        case 4 : Console.WriteLine("Voce escolheu a opção " + escolha); 
            break;
        case -1 : Console.WriteLine("Voce escolheu a opção " + escolha); 
            break;

        default: Console.WriteLine("Digite uma opção válida");
            break;
    }

}

ExibirMensagemDeBoasVindas();  
OpcoesDoMenu();
