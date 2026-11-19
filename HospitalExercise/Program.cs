/*No hospital "Só falta você", você foi contratado para gerenciar a ordem de atendimento do pronto socorro. 
 * Essa ordem segue a seguinte regra: 
 * para cada dois atendimentos da fila prioritária, um atendimento da fila normal é realizado. 
 * Faça um programa que gerencie essa fila usando senhas alfanuméricas como referência. 
 * Fila normal começa com N e tem um número aleatório na sequência. 
 * Fila prioritária começa com P e tem um número aleatório na sequência.*/

Queue priorityQueue = new Queue();
Queue normalQueue = new Queue();

Random random = new Random();

int priorityCounter = 0;


for (int i = 0; i < 11; i++)
{
    Console.WriteLine("Bem-vindo ao Hospital Só Falta Você! Se você for de algum grupo prioritário digite 1; Se estiver" +
        " aguardando e deseja uma senha geral, digite 2.");
    int passwordType = int.Parse(Console.ReadLine());

    if (passwordType == 1)
    {
        int number = random.Next(1, 30000);
        string name = $"P{number}";

        Password password1 = new Password(name);
        priorityQueue.InsertElement(password1);

        Console.WriteLine($"Sua senha é {password1.Name}");

    }
    else if (passwordType == 2)
    {
        int number = random.Next(1, 30000);
        string name = $"N{number}";

        Password password2 = new Password(name);
        normalQueue.InsertElement(password2);

        Console.WriteLine($"Sua senha é {password2.Name}");
    }
    else
    {
        Console.Write("Você digitou um número inválido.");
    }
}

void NextPatient(Queue priorityQueue, Queue normalQueue, ref int priorityCounter)
{
    if (priorityCounter < 2 && !priorityQueue.EmptyQueue())
    {
        Password called = priorityQueue.RemoveElement();

        Console.WriteLine($"Próximo atendimento: {called.Name}");

        priorityCounter++;
    }
    else if (!normalQueue.EmptyQueue())
    {
        Password called = normalQueue.RemoveElement();

        Console.WriteLine($"Próximo atendimento: {called.Name}");

        priorityCounter = 0;
    }
    else if (!priorityQueue.EmptyQueue())
    {
        Password called = priorityQueue.RemoveElement();

        Console.WriteLine($"Próximo atendimento: {called.Name}");

        priorityCounter++;
    }
    else
    {
        Console.WriteLine("As filas estão vazias.");
    }
}


//para chamar os pacientes
Console.WriteLine();
Console.WriteLine("=====Chamadas dos pacientes=====");

for (int i = 0; i < 11; i++)
{
    NextPatient(priorityQueue, normalQueue, ref priorityCounter);

    Console.WriteLine("\nPróximos da fila preferencial:");
    priorityQueue.ShowQueue();

    Console.WriteLine("\nPróximos da fila geral:");
    normalQueue.ShowQueue();
    Console.WriteLine("------------------");
}
