using FiguresArea.Shapes;

namespace FiguresArea.Tests;

public class Tests
{
    [Test]
    public void CircleAreaCalculation()
    {
        Circle circle = new Circle(5);
        double expectedArea = Math.PI * 25;
        double actualArea = circle.CalculateArea();
        Assert.AreEqual(expectedArea, actualArea, 0.001);
    }

    [Test]
    public void TriangleAreaCalculation()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        double actualArea = triangle.CalculateArea();
        Assert.AreEqual(expectedArea, actualArea, 0.001);
    }

    [Test]
    public void RightTriangleCheck()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        bool isRightTriangle = triangle.IsRightTriangle();
        Assert.IsTrue(isRightTriangle);
    }
}
