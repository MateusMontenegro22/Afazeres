using System.Runtime.CompilerServices;

namespace Afazeres;

internal class Tarefa
{
    public Tarefa(string nome, int tempoParaSerfeito, string observacao)
    {
        this.Nome = nome;
        this.TempoParaSerfeito = tempoParaSerfeito;
        this.Observações = observacao;
    }
    public string? Nome { get; }
    public int TempoParaSerfeito { get; }

    public string Observações { get; }

   public static void CadastrarTarefa(List<Tarefa> tarefas)
    {
        //Aqui conseguimos os dados da tarefa: nome e tempo de conclusão
        Console.WriteLine("Nome da Tarefa: ");
        string nomeDaTarefa = Console.ReadLine()!;
        Console.WriteLine("Tempo para concluir a tarefa (informar valor unico em minutos): ");
        string tempoConcluir = Console.ReadLine()!;
        int tempoConcluirConv = int.Parse(tempoConcluir);
        Console.WriteLine("Observação da tarefa: ");
        string observacao = Console.ReadLine()!;
        
        //Agora a baixo irei começar a construir a tarefa
        Tarefa tarefa = new(nomeDaTarefa, tempoConcluirConv, observacao);
        tarefas.Add(tarefa);
        Console.WriteLine("Cadastro de tarefa concluida");
        Thread.Sleep(1000);
        Menu menu = new Menu();
        menu.MostrarMenu();

    }
}
