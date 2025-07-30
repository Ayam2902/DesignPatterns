using FluentAssertions;
using Xunit;

public class Button_V1_Tests
{
    [Fact]
    public void TestFacoryButtonV1()
    {
        IButton btn = FactoryButton.getButton(Platform.IOS);
        btn.Should().BeOfType<RoundButton>("button should be of round subclass.");
    }
}