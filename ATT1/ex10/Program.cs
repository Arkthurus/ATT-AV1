/* Permita que o usuário adicione tarefas a uma lista e, ao final, mostre todas as tarefas
inseridas. Use List<string> e ofereça uma opção para marcar tarefas como
concluídas */


using System.ComponentModel;

internal class Program
{
    private static readonly List<string> todoList = [];
    private static readonly List<bool> concluidas = [];

    private static void Main(string[] args)
    {
        Console.WriteLine($"----- LISTA DE TAREFAS -----");

        while (true)
        {
            Console.WriteLine($"----------------------------");
            Console.WriteLine($"[1] Nova tarefa");
            Console.WriteLine($"[2] Concluir tarefa");
            Console.WriteLine($"[3] Listar tarefas");
            Console.WriteLine($"[4] Sair");
            Console.WriteLine($"----------------------------");

            var escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    NovaTarefa();
                    break;

                case "2":
                    ConcluirTarefa();
                    break;

                case "3":
                    ListarTarefas();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine($"Opção inválida!");
                    break;
            }
        }
    }

    private static void NovaTarefa()
    {
        string? descricao;
        do {
            Console.WriteLine($"Descreva a tarefa:");
            descricao = Console.ReadLine();
        } while(descricao is null);
        
        todoList.Add(descricao);
        concluidas.Add(false);
    }

    private static void ConcluirTarefa()
    {
        int index;

        do {
            ListarTarefas();

            Console.WriteLine($"Qual tarefa deseja concluir?");
            index = int.Parse(Console.ReadLine() ?? "-1") - 1;
            
            if (index < 0 || index > todoList.Count) {
                Console.WriteLine($"Tarefa inválida. Tente novamente.");
                continue;
            }

            if (concluidas[index]) {
                Console.WriteLine($"A tarefa {index} já está concluída!");
            }
        } while(index < 0 || index > todoList.Count || concluidas[index]);

        concluidas[index] = true;
        Console.WriteLine($"Tarefa concluída com sucesso!");
    }

    private static void ListarTarefas()
    {
        var i = 0;

        todoList.ForEach(
            tarefa => Console.WriteLine($"[{i + 1}] {tarefa} - {(concluidas[i++] ? "Concluída" : "A fazer")}")
        );
    }
}