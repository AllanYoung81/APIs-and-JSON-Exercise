using System;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();
            Console.WriteLine();
            QuoteGenerator.RonQuote();
            Console.WriteLine();
            //QuoteGenerator.KanyeQuote();
            //Console.WriteLine();
            //QuoteGenerator.RonQuote();
            //Console.WriteLine();
            //QuoteGenerator.KanyeQuote();
            //Console.WriteLine();
            //QuoteGenerator.RonQuote();
            //Console.WriteLine();

            OpenWeatherMapAPI.CurrentWeather();

        }
    }

}
