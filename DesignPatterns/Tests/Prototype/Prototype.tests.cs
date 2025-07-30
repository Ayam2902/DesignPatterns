using FluentAssertions;
using Xunit;

public class PrototypeTest{

    [Fact]
    public void TestPrototypePattern(){
        //Arrange
        Prototype pt = new Prototype(1,2);

        //Act
        Prototype pt2 = pt.clone();
        //Assert
        pt2.Should().NotBeNull();
        pt2.Should().NotBeSameAs(pt);
        pt2.Should().BeEquivalentTo(pt);
        
    }
}