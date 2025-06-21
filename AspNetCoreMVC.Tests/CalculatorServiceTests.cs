namespace AspNetCoreMVC.Tests;

public class CalculatorServiceTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var service = new CalculatorService();

        var result = service.Add(3, 4);

        Assert.Equal(7, result);
    }

    public void Subtract_ReturnsCorrectDifference()
    {
        var service = new CalculatorService();

        var result = service.Subtract(10, 4);

        Assert.Equal(6, result);
    }
}