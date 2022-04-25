using System;

namespace DIO.Series
{
    internal class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X"){
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VizualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void VizualizarSerie()
        {
            Console.Write("Digite o ID da Série a ser Vizualizada: ");
            int entradaId = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(entradaId);
            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o ID da Série a ser Excluída: ");
            int entradaId = int.Parse(Console.ReadLine());
            repositorio.Excluir(entradaId);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o ID da Série a Ser Atualizada: ");
            int entradaId = int.Parse(Console.ReadLine());

            //Exibir os generos para escolha do genero da atualizacao
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero),i)}");
            }

            Console.Write("Digite o Gênero Entre as Opções Acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie((Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno, entradaId);

            repositorio.Atualizar(entradaId, novaSerie);
        }

        private static void InserirSeries()
        {
            Console.WriteLine("Inserir Nova Série");

            //Exibir os generos para escolha do genero da nova serie
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero),i)}");
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie((Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno, repositorio.ProximoId());

            repositorio.Insere(novaSerie);
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhuma Série Cadastrada.");
                return;
            }
            else{
                foreach(var serie in lista){
                    var ehExcluido = serie.retornaExcluido() ? " - *Excluido*" : "";
                    Console.WriteLine($"#ID {serie.retornaId()}: {serie.retornaTitulo()}{ehExcluido}");
                }
            }

        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("DIO Series ao seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir Nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

