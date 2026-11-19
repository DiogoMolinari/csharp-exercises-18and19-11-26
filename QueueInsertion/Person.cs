public class Person
{
    public string Name { get; set; }
    public Person Next;

    public Person(string name)
    {
        Name = name;
        Next = null;
    }
}

