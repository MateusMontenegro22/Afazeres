using Afazeres.Banco;
using System.Runtime.CompilerServices;

namespace Afazeres;

internal class MenuCadastrarTarefa
{
  
   public static void CadastrarTarefa(List<Tarefas> tarefas)
    {
        //Aqui conseguimos os dados da tarefa: nome e tempo de conclusão
        Console.Clear();
        Console.WriteLine("Nome da Tarefa: ");
        string nomeDaTarefa = Console.ReadLine()!;
        Console.WriteLine("Tempo para concluir a tarefa (informar valor unico em minutos): ");
        string tempoConcluir = Console.ReadLine()!;
        Console.WriteLine("Observação da tarefa: ");
        string observacao = Console.ReadLine()!;

        //Agora a baixo irei começar a construir a tarefa
        Tarefas tarefa = new(nomeDaTarefa, tempoConcluir, observacao);
        tarefas.Add(tarefa);
        TarefaDal.AdicionarTarefa(tarefa);

        Console.WriteLine("Cadastro de tarefa concluida");
        Thread.Sleep(1000);
        Console.Clear();
        Menu.MostrarMenu();

    }
}
