namespace Afazeres;
internal class MenuExcluirTarefa
{
    public static void ExcluirTarefa(List<Tarefas> tarefas)
    {
        //Tarefas tarefaExlcuida = new();
        Console.Clear();
        Console.WriteLine("Digite o Id da tarefa que deseja excluir");
        var idSelecionado = Console.ReadLine()!;
        var idSelecionadoConv = int.Parse(idSelecionado);

        if (idSelecionadoConv == tarefas[idSelecionadoConv].Equals()) { }
        
    }

}
