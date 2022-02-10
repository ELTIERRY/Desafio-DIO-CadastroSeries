namespace Exercicio.CadastroSeries.Dio
{
    public interface ICadSeries
    {
        void ListarSeries(int id);
        void AtualizarSeries(Genero genero, string titulo, string descricao, int ano);
        void ExluirSeries();
        void VisualizarSerie(int id);

    }
}