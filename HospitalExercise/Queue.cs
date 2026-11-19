public class Queue
{
    public Password Head;
    public Password Tail;

    public bool EmptyQueue()
    {
        return Head == null;
    }

    public void InsertElement(Password aux)
    {
        if (EmptyQueue())
        {
            Head = aux;
            Tail = aux;
        }
        else
        {
            Tail.Next = aux;
            Tail = aux;
        }
    }

    public Password RemoveElement()
    {
        if (EmptyQueue())
        {
            return null;
        }

        Password removed = Head;
        Head = Head.Next;

        if (Head == null)
        {
            Tail = null;
        }

        return removed;
    }
    public void ShowQueue()
    {
        Password aux = Head;

        if (EmptyQueue())
        {
            Console.WriteLine("Fila vazia.");
            return;
        }

        while (aux != null)
        {
            Console.WriteLine(aux.Name);
            aux = aux.Next;
        }
    }
}
