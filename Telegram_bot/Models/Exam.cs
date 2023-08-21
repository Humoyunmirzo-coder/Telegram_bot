namespace Telegram_bot.Models
{
    internal class Exam
    {
        private object subject;
        private object date;
        private int score;

        public Exam(object subject, object date, int score)
        {
            this.subject = subject;
            this.date = date;
            this.score = score;
        }
    }
}