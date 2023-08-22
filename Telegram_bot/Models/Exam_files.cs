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
    }
}
