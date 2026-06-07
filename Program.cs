/*Lista lista = new Lista();

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

} while (opcao != 0);*/

ListaFuncionario lista = new ListaFuncionario();

int opcao;

do
{
    Console.WriteLine("\n===== MENU - LISTA DE FUNCIONÁRIOS =====");
    Console.WriteLine("1 - Inserir funcionário no início");
    Console.WriteLine("2 - Inserir funcionário no fim");
    Console.WriteLine("3 - Buscar funcionário por nome");
    Console.WriteLine("4 - Remover funcionário do início");
    Console.WriteLine("5 - Remover funcionário do fim");
    Console.WriteLine("6 - Imprimir lista");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o nome: ");
            string nomeInicio = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idadeInicio = int.Parse(Console.ReadLine());

            Console.Write("Digite o telefone: ");
            string telefoneInicio = Console.ReadLine();

            Console.Write("Digite o salário: ");
            double salarioInicio = double.Parse(Console.ReadLine());

            lista.inserirInicio(nomeInicio, idadeInicio, telefoneInicio, salarioInicio);
            break;

        case 2:
            Console.Write("Digite o nome: ");
            string nomeFim = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idadeFim = int.Parse(Console.ReadLine());

            Console.Write("Digite o telefone: ");
            string telefoneFim = Console.ReadLine();

            Console.Write("Digite o salário: ");
            double salarioFim = double.Parse(Console.ReadLine());

            lista.inserirFim(nomeFim, idadeFim, telefoneFim, salarioFim);
            break;

        case 3:
            Console.Write("Digite o nome que deseja buscar: ");
            string nomeBusca = Console.ReadLine();

            if (lista.buscarPorNome(nomeBusca))
            {
                Console.WriteLine("Funcionário encontrado!");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }

            break;

        case 4:
            lista.removerInicio();
            break;

        case 5:
            lista.removerFim();
            break;

        case 6:
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