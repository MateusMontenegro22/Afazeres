namespace Afazeres;

public class Tarefas
{
    public Tarefas(string nome, string tempoParaSerfeito, string obs)
    {
        Nome = nome;
        TempoParaSerfeito = tempoParaSerfeito;
        Obs = obs;
    }
    public string Nome { get; set; }
    public string TempoParaSerfeito { get; set; }
    public int Id { get; set; }
    public string Obs { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}  " + $" Tarefa:{Nome} " +  $"Tempo para ser feito: {TempoParaSerfeito}"+ $"Observações: {Obs}" ;
    }

}
