using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Title/Header
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        
        //Questions asked by console
        //Then answers from users input are read and placed in variable
        Console.WriteLine("What is your name?");
        string usersName = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number?");
        var pageNumber = Console.ReadLine();

        Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
        string usersHelp = Console.ReadLine();
        //Converts users answer to boolean
        bool usersHelpBool = Convert.ToBoolean(usersHelp);

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string usersExperiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string usersFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        var usersHours = Console.ReadLine();
        
        // End of program
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!") ;
        Console.ReadLine();
        
        // Test
        //Console.WriteLine(usersName + courseName + pageNumber + usersHelpBool + usersExperiences + usersFeedback + usersHours);
    }
}
