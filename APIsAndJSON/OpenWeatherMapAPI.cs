using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class OpenWeatherMapAPI

{

    public static void CurrentWeather()

    {
        Console.WriteLine("Please enter your city: ");
        string cityName = Console.ReadLine();
        string API = File.ReadAllText("AppSettings.json");
        string weatherAPI = JObject.Parse(API).GetValue("ConnectionStrings").ToString();
        
         
        
        HttpClient client = new HttpClient();
        string endpoint = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={weatherAPI}&units=imperial";
       

        string weatherResponse = client.GetStringAsync(endpoint).Result;
        

        JObject weatherObject = JObject.Parse(weatherResponse);
        decimal temp = (decimal)weatherObject["main"]["temp"];

        Console.WriteLine(temp);



    }


}

