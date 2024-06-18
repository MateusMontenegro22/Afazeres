namespace Afazeres;
//teste
public class Menu
{
public void MostrarMenu()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        Console.WriteLine("TAREFINHAS A FAZER\n\n");
        Console.WriteLine("MENU - Escolha uma opção\n");
        Console.WriteLine("1 - Cadastrar tarefa.");
        Console.WriteLine("2 - Excluir tarefa.");
        Console.WriteLine("3 - Listar tarefas cadastradas.");

        string opçaoEscolhida = Console.ReadLine()!;
        int opçaoEscolhidaConv = int.Parse(opçaoEscolhida);

        switch (opçaoEscolhidaConv)
        {
            case 1:
                Tarefa.CadastrarTarefa(tarefas);
                break;
            case 2:
                ExcluirTarefa();
                break;
            case 3:
                ListarTarefas();
                break;
        }
       
    }    

}
