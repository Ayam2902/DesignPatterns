public class EmailService : IObserver
{
    public void consume()
    {
        Console.WriteLine("Calling consume from notify.");
    }
}