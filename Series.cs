using System;

namespace Exercicio.CadastroSeries.Dio
{
    public class Series : ICadSeries
    {
        private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool StatusSerie {get; set;}

        // Método construtor para inserir as séries
        public Series(Genero genero, string titulo, string descricao, int ano)
		{
			Genero = genero;
			Titulo = titulo;
			Descricao = descricao;
			Ano = ano;
            StatusSerie = false;
		}

        public void ListarSeries(int id) 
        {
            Console.WriteLine("#{0}\t{1}\t{2}", id, Titulo, (StatusSerie ? "(Inativa)" : "(Ativa)"));
        }

        public void AtualizarSeries(Genero genero, string titulo, string descricao, int ano)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }
        public void ExluirSeries()
        {
            StatusSerie = !StatusSerie;
        }
        public void VisualizarSerie(int id)
        {
            Console.WriteLine("#ID: {0}\n" +
                            "Genero: {1}\n" + 
                            "Titulo: {2}\n" + 
                            "Descricao: {3}\n" + 
                            "Ano: {4}\n" + 
                            "Status: {5}\n"
                            , id, Genero, Titulo, Descricao, Ano, (StatusSerie ? "(Inativa)" : "(Ativa)"));
            Console.WriteLine();
        }
    }
}