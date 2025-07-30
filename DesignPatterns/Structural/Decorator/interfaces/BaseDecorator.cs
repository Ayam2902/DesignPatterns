public abstract class BaseDecorator : IDatabase
{
    IDatabase db;

    public BaseDecorator(IDatabase db)
    {
        this.db = db;
    }
    public abstract void read();
    public abstract void write();
}