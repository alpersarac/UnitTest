namespace UnitTest
{
    public class DegreeConverter
    {
        public double ToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        public double ToCelcius(double fahrenheit)
        {
            return (32*fahrenheit-32 ) *5/9;
        }
    }
}
