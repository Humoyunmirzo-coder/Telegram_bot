using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram_bot.Models
{
    public class User
    {
        public User() { }

        public int Id { get; set; }
        public string Name { get; set; }
     
        public User (int id, string name)
        {
            Id = id;
            Name = name;    
        }
       public void User_Check ( int Id , string Name )
        {
            Console.Write(" Enter your id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write(" Enter your Name: ");
            string name = Console.ReadLine();
            if ( Id == id && Name == name)
            {
                Console.WriteLine(" welcome to your accaunt ");
                
            }
        }
    }
}
