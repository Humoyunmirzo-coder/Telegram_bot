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
        User user = new User( );
        Exam_files exam_Files = new Exam_files();
        exam_Files.TextWrite("hello");
        user.User_Check(11 ,"Sardor");

        student.Add_list();
    }
}