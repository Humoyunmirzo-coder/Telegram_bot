using System.Globalization;
using System.Security.Cryptography;
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

        User user = new User( );
        user.User_Check(11 ,"Sardor");

        Exam_files exam_Files = new Exam_files();
        exam_Files.TextWrite("hello");
        exam_Files.TextWrite("SARDOR");
        exam_Files.TextWrite("KAMOL");
        exam_Files.TextWrite("ODIL");
        exam_Files.Start();
      
        Examiner examiner = new Examiner();
        examiner.Examiners();
      
    }
}