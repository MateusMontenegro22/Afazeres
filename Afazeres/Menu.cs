namespace Afazeres;
//teste
public class Menu
{
public static void MostrarMenu()
    {
        List<Tarefas> tarefas = new List<Tarefas>();
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
                MenuCadastrarTarefa.CadastrarTarefa(tarefas);
                break;
            case 2:
                //ExcluirTarefa(); 
                break;
            case 3:
                MenuListarTarefas.ListarTarefas(tarefas);
                break;
        }
       
    }    

}
