namespace View
{
    public class Rota
    {
        public static void CadastrarRota() {
            Console.WriteLine("Cadastrar Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Origem:");
            string origemId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("Valor:");
            double valor = double.Parse(Console.ReadLine()); 
            try {
                Controller.Rota.CadastrarRota(id, origemId, destinoId, caminhaoId, data, valor);
                Console.WriteLine("Rota cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void AlterarRota() {
            Console.WriteLine("Alterar Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Origem:");
            string origemId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("Valor:");
            double valor = double.Parse(Console.ReadLine());
            try {
                Controller.Rota.AlterarRota(id, origemId, destinoId, caminhaoId, data, valor);
                Console.WriteLine("Rota alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ExcluirRota() {
            Console.WriteLine("Excluir Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            try {
                Controller.Rota.ExcluirRota(id);
                Console.WriteLine("Rota excluída com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListarRotas() {
            Console.WriteLine("Listar Rotas");
            foreach (string rota in Controller.Rota.ListarRotas()) {
                Console.WriteLine(rota);
            }
        }    
    }
}