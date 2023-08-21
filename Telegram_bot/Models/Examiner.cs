using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Telegram_bot.Models
{
    internal class Examiner
    {
        private string name;

        public Examiner() { }
        public Examiner(int id, string name)
        {
            Id = id;
            Name = name;
        }
    
        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
               
                if (value == null)
                {
                  
                    throw new ArgumentNullException(nameof(value), "Name cannot be null");
                }
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty", nameof(value));
                }
                if (value.Length > 3)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name must have more than 3 characters", nameof(value));
                }
            }
        }


        public void Examiners()
        {
            Console.Write("Enter your Id:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            if (name == Name && id == Id)
            {
                Console.WriteLine(" welcome your accaunt");
            }
        }

    }
}
