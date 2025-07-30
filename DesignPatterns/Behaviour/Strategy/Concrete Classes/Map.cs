public class Map
{
    private INavigate strategy;

    public Map(INavigate obj)
    {
        this.strategy = obj;
    }

    public void navigate(string to, string from)
    {
        strategy.navigate(to, from);
    }
}