public class DarkFormFactory : IFormFactory
{
    public IButtonAbstractFactory createButton()
    {
        return new DarkButton();
    }

    public ICheckBox createCheckBox()
    {
        return new DarkCheckBox();
    }
}
