Lista lista = new Lista();

int opcao;

do
{
    Console.WriteLine("1 - Inserir no início");
    Console.WriteLine("2 - Inserir no fim");
    Console.WriteLine("3 - Remover do início");
    Console.WriteLine("4 - Remover do fim");
    Console.WriteLine("5 - Imprimir lista");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o valor: ");
            int valorInicio = int.Parse(Console.ReadLine());

            lista.inserirInicio(valorInicio);
            break;

        case 2:
            Console.Write("Digite o valor: ");
            int valorFim = int.Parse(Console.ReadLine());

            lista.inserirFim(valorFim);
            break;

        case 3:
            lista.removerInicio();
            break;

        case 4:
            lista.removerFim();
            break;

        case 5:
            lista.imprimir();
            break;

        case 0:
            Console.WriteLine("Programa encerrado.");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (opcao != 0);