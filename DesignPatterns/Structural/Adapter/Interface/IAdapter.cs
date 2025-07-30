public interface IAdapter
{

    // We can also standardize the arguments and the return type of interface methods here, which the inheriting adapter classes will 
    // need to handle for their respective third party API's
    public void pay();

    public void checkStatus();
}