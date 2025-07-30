public class LightFormFactory : IFormFactory
{
    public IButtonAbstractFactory createButton()
    {
        return new LightButton();
    }

    public ICheckBox createCheckBox()
    {
        return new LightCheckBox();
    }
}
