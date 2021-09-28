using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Working_With_Dates_and_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine (@"Make a  selection of the program you want to access from the follow: 
- Input 'C' for Consecutive Numbers;
- Input 'D' for  Duplicate of Numbers;
- Input 'T' for Time Determinant;
- Jnput 'P' for Pascal Case;
- Input 'E' for English Word");

                var selection = (string)Console.ReadLine (); // Making selection of the program to access.


                const string consecutive = "c";
                const string duplicate = "d";
                const string time = "t";
                const string pascal = "p";
                const string english = "e";

                switch ( selection.ToLower () )
                {
                    case consecutive:
                        Console.WriteLine ();
                        Console.WriteLine (@"You selected Consecutive Numbers.
This program displays whether the user input are consecutive numbers or not.");
                        Console.WriteLine ("Enter a few numbers separated by hyphen");
                        //Console.WriteLine();
                        var nums = Console.ReadLine ();
                        Console.WriteLine (DateTime_and_Strings.ConsecutiveNumbers (nums)); // Accessing ConsecutiveNumbers method of DateTime_and_Strings class
                        Console.WriteLine ();
                        continue;

                    case duplicate:
                        Console.WriteLine ();
                        Console.WriteLine (@"You selected Duplicate of Numbers
This program display the duplicate of the user input.");
                        Console.WriteLine ("Enter a few numbers separated by hyphen. ");
                        var numberInput = Console.ReadLine ();
                        Console.WriteLine (DateTime_and_Strings.DuplicateNumbers (numberInput)); // Accessing DuplicateNumbers method of DateTime_and_Strings class
                        Console.WriteLine ();
                        continue;

                    case time:
                        Console.WriteLine ();
                        Console.WriteLine (@"You selected Time Determinant
This program determine the validity of  time value input.");
                        Console.WriteLine ("Enter a time value in 24 hours format between 00:00 and 23:59 (e.g 19:00). ");

                        var timeInput = Console.ReadLine ().Trim ();

                        Console.WriteLine (DateTime_and_Strings.TimeDeterminant (timeInput)); // Accessing TimeDeterminant method of DateTime_and_Strings class
                        Console.WriteLine ();
                        continue;

                    case pascal:
                        Console.WriteLine ();
                        Console.WriteLine ("You selected Pascal Case");
                        Console.WriteLine ("Enter a few words separated by space. ");
                        //Console.WriteLine();
                        Console.WriteLine (DateTime_and_Strings.PascalCase ()); // Accessing PascalCase method of DateTime_and_Strings class
                        Console.WriteLine ();
                        continue;

                    case english:
                        Console.WriteLine ();
                        Console.WriteLine ("You selected English Word");
                        Console.WriteLine ("Enter an English word. ");
                        //Console.WriteLine();
                        Console.WriteLine (DateTime_and_Strings.EnglishWord ()); // Accessing EnglishWord method of DateTime_and_Strings class
                        Console.WriteLine ();
                        continue;

                    default:
                        Console.WriteLine ();
                        Console.WriteLine ("You've made an invalid selection");
                        Console.WriteLine ();
                        break;
                }
                break;


            } while ( true );


        }


    }


}
