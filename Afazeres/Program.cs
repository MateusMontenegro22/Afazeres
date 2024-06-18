using Afazeres;


List<Tarefa> tarefas = new List<Tarefa>();
//menu
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
        CadastrarTarefa(tarefas);
        break;
    case 2:
        ExcluirTarefa();
        break;
    case 3:
        ListarTarefas();
        break;
}
//------
void ListarTarefas()
{

}

static void CadastrarTarefa(List<Tarefa> tarefas)
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
    Tarefa tarefa = new(nomeDaTarefa, tempoConcluirConv);
    tarefas.Add(tarefa);

}
void ExcluirTarefa()
{
   
}

