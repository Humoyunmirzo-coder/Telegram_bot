﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Telegram_bot.Models
{
    public class Exams
    {
      
        static string token = "YOUR_BOT_TOKEN_HERE";


        private List<int> exam = new List<int>();
        

        public List<int> Exam { get => exam; set => exam = value; }

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

