
using GeometryClassLibrary;

namespace GeometryTestLibrary;


[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculateArea();

        // Assert
        Assert.AreEqual(25, result);
    }
}
    