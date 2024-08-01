namespace Exe3.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(20, 68)]
        [InlineData(23, 73.4)]
        public void Test1(double celsius, double esperado)
        {
            Temperatura temperatura = new();

            double temperaturaEmFahrenheit = temperatura.ConverterCelsiusParaFahrenheit(celsius);



            Assert.Equal(esperado, temperaturaEmFahrenheit);
            Assert.Equal(esperado, temperaturaEmFahrenheit);

        }
    }
}