public class BitcoinTracker : Publisher
{
    private Bitcoin bitcoin;
    

    public BitcoinTracker(Bitcoin bitcoin)
    {
        this.bitcoin = bitcoin;
    }

    public void setValue(int val)
    {
        bitcoin.value = val;
        notify();
    }
}