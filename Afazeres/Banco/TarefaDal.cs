using Afazeres;
namespace Afazeres.Banco;
internal class TarefaDal
{
    public IEnumerable<Tarefas> Listar()
    {
        using var context = new AfazeresContext();
        return context.Tarefas.ToList();
    }
}
