var money = new Money(100);
var money2 = new Money();
var MoneyStack = new Stacks();


int x = 10;

do
{
    var m = new Money(Random.Shared.Next(1,100));
    Console.WriteLine(m);

    MoneyStack.AddElement(m);
    Thread.Sleep(1000);
    Console.Clear();
    x--;

} while (x > 0);

Console.WriteLine("Mostrando a pilha criada...\n");
MoneyStack.ShowStack();

Thread.Sleep(3000);

Console.Clear();

while (MoneyStack.ElementCount() != 0)
{
    MoneyStack.RemoveElement();
    if (MoneyStack.IsEmpty())
        break;
    MoneyStack.ShowStack();
    Thread.Sleep(1000);
    Console.Clear();

}

Console.ReadLine();