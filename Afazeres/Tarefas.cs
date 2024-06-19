namespace Afazeres;

internal class Tarefas
{
    public Tarefas(string nome, int tempoParaSerfeito, string observacao)
    {
        this.Nome = nome;
        this.TempoParaSerfeito = tempoParaSerfeito;
        this.Observações = observacao;
    }
    public string Nome { get; }
    public int TempoParaSerfeito { get; }

    public string Observações { get; }

}
