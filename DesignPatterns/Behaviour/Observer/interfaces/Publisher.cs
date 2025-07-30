public abstract class Publisher
{
    private List<IObserver> observers = new List<IObserver>();
    public void notify()
    {
        foreach (var item in observers)
       {
            item.consume();
       }
    }
    public void subscribe(IObserver obj)
    {
        observers.Add(obj);
    }
    public void unSubscribe(IObserver obj)
    {
        observers.Remove(obj);
    }
}