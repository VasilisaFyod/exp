namespace app;

public class UnitTest1
{
    [Fact]
    public void PositiveTest()
    {
        //Arrange
        double T0 = 100;
        double Tenv = 20;
        double k = 0.1;
        double t = 0;
        double ExpResult = 100;

        //Act
        double ActResult = NewtonCoolingModel.CalculateTemperature(T0, Tenv, k, t);

        //Assert
        Assert.Equal(ExpResult, ActResult);
    }
}
