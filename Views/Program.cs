namespace Retaguarda
{
    public class Principal
    {
        public static void Main(string[]  args)
        {
            int opcao = 99;
            do {
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|       MENU PRINCIPAL     |");
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("| 1  - CADASTRAR ROTAS     |");
            Console.WriteLine("| 2  - ALTERAR ROTAS       |");
            Console.WriteLine("| 3  - EXCLUIR ROTAS       |");
            Console.WriteLine("| 4  - LISTAR ROTAS        |");
            Console.WriteLine("| 5  - CADASTRAR CAMINHAO  |");
            Console.WriteLine("| 6  - ALTERAR CAMINHAO    |");
            Console.WriteLine("| 7  - EXCLUIR CAMINHAO    |");
            Console.WriteLine("| 8  - LISTAR CAMINHAO     |");
            Console.WriteLine("| 9  - CADASTRAR CIDADE    |");
            Console.WriteLine("| 10 - ALTERAR CIDADE      |");
            Console.WriteLine("| 11 - EXCLUIR CIDADE      |");
            Console.WriteLine("| 12 - LISTAR CIDADE       |");
            Console.WriteLine("| 99 - Sair do Sistema.    |");
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("DIGITE A OPCAO DESEJADA: ");
            opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 0:
                        Console.WriteLine("PROGRAMA FECHADO!");
                        break;
                    case 1:
                        View.Rota.CadastrarRota();
                        break;
                    case 2:
                        View.Rota.AlterarRota();
                        break;
                    case 3:
                        View.Rota.ExcluirRota();
                        break;
                    case 4:
                        View.Rota.ListarRotas();
                        break;
                    case 5:
                        View.Caminhao.CadastrarCaminhao();
                        break;
                    case 6:
                        View.Caminhao.AlterarCaminhao();
                        break;
                    case 7:
                        View.Caminhao.ExcluirCaminhao();
                        break;
                    case 8:
                        View.Caminhao.ListarCaminhoes();
                        break;
                    case 9:
                        View.Cidade.CadastrarCidade();
                        break;
                    case 10:
                        View.Cidade.AlterarCidade();
                        break;
                    case 11:
                        View.Cidade.ExcluirCidade();
                        break;
                    case 12:
                        View.Cidade.ListarCidades();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
