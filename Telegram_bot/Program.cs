using System.Globalization;
using Telegram_bot.Models;

internal class Program
{
    private static void Main(string[] args)
    {
     
        Student student = new Student();
        student.Address = " Fergana";
        student.LastName = "Humoyunmirzo";
        student.FirstName = "Gafforov";
        student.Age = 22;
        student.Id =11;
        student.Add_list();
    }
}