public class Queue
{
    public Person Head;
    public Person Tail;
    public int Accountant;

    public Queue()
    {
        Head = Tail = null;
        Accountant = 0;
    }
    public bool EmptyQueue()
    {
        if (Head == null)
        {
            return true;
        }
        return false;
    }

    public void InsertionElement(Person aux)
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
        Accountant++;
    }

    public int GetAccountant()
    {
        return Accountant;
    }

    public void RemoveElement()
    {
        if (!EmptyQueue())
        {
            Head = Head.Next;
            Accountant--;
        }
        else
        {
            Head = Tail = null;
        }
    }

    public void ShowQueue()
    {
        Person p = Head;
        for (int i = 0; i <= Accountant; i++)
        {
            if (p == null)
            {
                Console.WriteLine("Acabou a fila!");
                break;
            }
            Console.Write(p.Name + " => ");
            p = p.Next;
        }
    }
}

