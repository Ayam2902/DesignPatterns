public class CompressionDecorator : IDatabase
{
    IDatabase db;

    public CompressionDecorator(IDatabase db)
    {
        this.db = db;
    }
    public void read()
    {
        db.read();
        string decompress = "";
        
    }

    public void write()
    {
        string compress ="";
        db.write();
        
    }
}
