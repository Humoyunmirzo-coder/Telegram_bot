using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram_bot.Models
{
    public class Student : User, IComparable<Student>
    {
        public Student() { }
    

        public int Id { get; set; } 
        public string  FirstName { get; set; }
        public string LastName { get; set; }    
        public int Age { get; set; }
        public string Address { get; set; }


        public Student (int id , string firstname  , string lastname , int age , string address)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Address = address;
        }
        string path = "C:\\HP\\PDP.txt";

        public void  Add_list ()
        {
            
            File.Create(path); Console.WriteLine(" File Create "); 
            if (File.Exists(path))
            {

               Console.WriteLine("File exists ");
               Console.Write(" Enter your text: ");
            string WriteText = Console.ReadLine();
             File.WriteAllTextAsync(path , WriteText) ;
            }

         
                 
          

        }

        int IComparable<Student>.CompareTo(Student? other)
        {
            throw new NotImplementedException();
        }
    }


    
    class Student2
    {
        public string Address { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public Student2(string address, string lastName, string firstName, int age, int id)
        {
       
            Address = address;
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Id = id;
        }
    }

  

}
