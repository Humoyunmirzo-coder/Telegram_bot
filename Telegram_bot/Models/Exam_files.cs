using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram_bot.Models
{
    internal class Exam_files
    {
        public Exam_files() { }

        string path = "C:\\HP\\PDP.txt";
        public void TextWrite (string text)
        {
            File.WriteAllText(path, text);

        }
        public void Start()
        {
            Console.Write( "Eneter your Id:  ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();   

        }

        public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
            public string? SummaryField;
            public IList<DateTimeOffset>? DatesAvailable { get; set; }
            public Dictionary<string, User>? TemperatureRanges { get; set; }
            public string[]? SummaryWords { get; set; }
        }

    }

}
