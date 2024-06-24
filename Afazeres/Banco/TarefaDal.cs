using Afazeres;
namespace Afazeres.Banco;
internal class TarefaDal
{

    public IEnumerable<Tarefas> Listar()
    {
        using var context = new AfazeresContext();
        return context.Tarefas.ToList();
    }

    public static void AdicionarTarefa(Tarefas tarefa)
    {
        using var context = new AfazeresContext();
        context.Tarefas.Add(tarefa);
        context.SaveChanges();
    }
    public static void ExcluirTarefa(Tarefas tarefa)
    {
        using var context = new AfazeresContext();
        context.Tarefas.Remove(tarefa);
    }
}
