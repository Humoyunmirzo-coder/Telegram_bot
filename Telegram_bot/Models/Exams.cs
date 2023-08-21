using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Telegram_bot.Models
{
    public class Exams
    {
      
        static string token = "YOUR_BOT_TOKEN_HERE";

     


        static async Task HandleCommandAsync(Telegram.Bot.Types.Message message)
        {
            if (message is null)
            {
                throw new ArgumentNullException(nameof(message));
            }





            static string ExamsToString(Exams exams)
            {
                var sb = new StringBuilder();


                return sb.ToString();
            }



        }
    }
}

