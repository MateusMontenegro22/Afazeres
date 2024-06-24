namespace Afazeres;

internal class MenuListarTarefas
{
    public static void ListarTarefas(List<Tarefas> tarefas)
    {
        Console.Clear();
        Console.WriteLine("Lista de tarefas cadastradas\n");
        tarefas.ToList().ToString();
        Menu.MostrarMenu();

    }
}
