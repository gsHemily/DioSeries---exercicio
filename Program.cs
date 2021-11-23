using System;

namespace DioSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string OpcaoUsuario = ObterOpcaoDoUsuario;

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        ListaSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default;
                        throw new ArgumentOutOfRangeException();

                }
                

            }
            Console.WriteLine("obrigado por utilizar nossos serviços");
            Console.ReadLine();
        }

        private static void ListaSeries()
        {
            Console.WriteLine("Listar Series");
            var lista = repositorio.lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie cadastrada");
                return;
            }

            foreach (var series in lista)
            {
                var excluido = series.retornaExcluido();

                Console.WriteLine("#Id {0}:{1}{2}", series.retornaID(), series.retornaTitulo(), (excluido ? "Excluido" : " "));
            }
        }
        private static void InserirSeries()
        {
            Console.WriteLine("Inserir nova serie?");
            foreach (int i in Enum.GetValues(typeof(Genero))) ;

            Console.WriteLine("#Id {0}:{1}", 1, Enum.GetName(typeof(Genero), 1));

            Console.WriteLine("Qual genero?");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual Titulo?");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Qual Ano de inicio da serie?");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual descrição da serie?");
            string entradaDescricao = Console.ReadLine();

            Series novaSeries = new Series(ID: repositorio.Proximo()),
                                        Genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

            repositorio.Insere(novaSeries);

        }
        private static void AtualizarSeries()
        {
            Console.WriteLine("Digite o Id da serie:");
            int indiceSeries = int.Parse(Console.ReadLine());


            foreach (int i in Enum.GetValues(typeof(Genero))) ;

            Console.WriteLine("#Id {0}:{1}", 1, Enum.GetName(typeof(Genero), 1));

            Console.WriteLine("Qual genero citado acima?");
            int entradagenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual Titulo da serie?");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Qual Ano de inicio da serie?");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual descrição da serie?");
            string entradaDescrição = Console.ReadLine();

            Series atualizaSeries = new Series(ID: indiceSeries,
                            genero: (Genero)entradagenero,
                            titulo: entradaTitulo,
                            ano: entradaAno,
                            descricao: entradaDescrição);


            repositorio.Atualiza(indiceSeries, atualizaSeries);
        }
        private static void ExcluirSerie()

        {
            Console.WriteLine("Digite o Id da serie?");
            int indiceSeries = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceSeries);
        }
        private static void VisualizarSeries()
        {
            Console.WriteLine("Digite o Id da serie?");
            int indiceSeries = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorID(indiceSeries);

            Console.WriteLine("Serie");
        }

        private static string ObterOpcaoDoUsuario()

        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada?");

            Console.WriteLine("1 - Lista series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 - Visualizar serie");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;
        }





    }
}












