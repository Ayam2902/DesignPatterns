//Step-3: Create the Factory class

public class FactoryButton
{
    //Step-4 Create static method to get the instance of subclasses based on condition
    public static IButton getButton(Platform platform)
    {
        
        switch (platform)
        {
            case Platform.IOS:
                return new RoundButton();

            case Platform.Android:
                return new PrimaryButton();
        }

        throw new ArgumentException("Invalid Platform type");
    }
}