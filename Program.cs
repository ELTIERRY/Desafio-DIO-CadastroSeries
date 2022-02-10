using System.Collections.Generic;
using System;

namespace Exercicio.CadastroSeries.Dio
{
    class Program
    {
        static List<Series> listaDeSeries = new List<Series>();
        
        static void Main()
        {  
            Console.WriteLine("Bem vindo ao nosso serviço de cadastros de series");
            Apresentacao();
        }    
            
        static void Apresentacao()
        {
            Console.WriteLine("=================================");
            Console.Write("Informe a opção desejada:\n"+
                            "1- Listar séries\n"+
                            "2- Inserir nova série\n"+
                            "3- Atualizar série\n"+
                            "4- Ativar/Desativar série\n"+
                            "5- Visualizar série\n"+
                            "L- Limpar Tela\n"+
                            "Ou opção diferente para sair: ");

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();                            
            
            switch (opcao)
            {
                case "1":
                    Console.WriteLine();
                    ListaSeries();
                    break;
                case "2":
                    Console.WriteLine();
                    InsereSeries();
                    break;
                case "3":
                    Console.WriteLine();
                    AtualizaSeries();
                    break;
                case "4":
                    Console.WriteLine();
                    AtivaDesativaSeries();
                    break;
                case "5":
                    Console.WriteLine();
                    VisualizaSerie();
                    break;
                case "L":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Obrigado por uitlizar nossos serviços. Até logo!\n");
                    Environment.Exit(0);
                    break;
            }
            Apresentacao();      			
        }
        static void ListaSeries()
        {
            if (ValidarSerie(0))
            {
                Console.WriteLine("Listar Series...........................");
                //Console.WriteLine("ID\tTitulo\t\tStatus");

                int idSerie = 0;
                foreach (var serie in listaDeSeries)
                {
                    serie.ListarSeries(idSerie);
                    idSerie ++;
                }
            }
        }
        static void InsereSeries()
        {
            Console.WriteLine("Inserir nova série..........\n");

            foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

            Console.WriteLine();
            Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();
            Console.WriteLine();

			var novaSerie = new Series(genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			listaDeSeries.Add(novaSerie);
            listaDeSeries[listaDeSeries.Count-1].VisualizarSerie(listaDeSeries.Count-1);
        }
        static void AtualizaSeries()
        {
            Console.WriteLine("=====Atualizar Series===============");
            Console.Write("Digite o id da série: ");
            

			int indiceSerie = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ValidarSerie(indiceSerie))
            {
                listaDeSeries[indiceSerie].VisualizarSerie(indiceSerie);

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.WriteLine();
                Console.Write("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o Título da Série: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o Ano de Início da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                listaDeSeries[indiceSerie].AtualizarSeries(genero: (Genero)entradaGenero,
                                                                    titulo: entradaTitulo,
                                                                    ano: entradaAno,
                                                                    descricao: entradaDescricao);
            }
        } 
        static void AtivaDesativaSeries()
        {
            Console.WriteLine("=====Ativar Desativar Series===============");
            Console.Write("Digite o ID da Serie: ");
            int IdSerieExcluir = Convert.ToUInt16(Console.ReadLine());

            if (ValidarSerie(IdSerieExcluir))
            {
                listaDeSeries[IdSerieExcluir].ExluirSeries();
                Console.WriteLine();
                listaDeSeries[IdSerieExcluir].VisualizarSerie(IdSerieExcluir);
            }
    } 

        static void VisualizaSerie()
        {

            Console.WriteLine("Visualizar Series...........................");
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ValidarSerie(indiceSerie))
            {
                listaDeSeries[indiceSerie].VisualizarSerie(indiceSerie);
            }
        }

        static bool ValidarSerie(int numValSerie) //Verifica se existe serie criada
        {
            if (numValSerie <= listaDeSeries.Count - 1)
            {
                return true;
            }
            Console.WriteLine();
            Console.WriteLine("******Serie inexistente******");
            Console.WriteLine();
            return false;
            
        }

        
        
    }
}
