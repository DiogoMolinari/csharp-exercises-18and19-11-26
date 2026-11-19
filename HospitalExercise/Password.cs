public class Password
{
    public string Name { get; set; }
    public Password Next { get; set; }

    public Password(string name)
    {
        Name = name;
    }
}

