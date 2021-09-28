using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Dates_and_Text
{
    public class DateTime_and_Strings
    {
        public static string ConsecutiveNumbers(string seriesNum)
        {
            
            var numberArray = Array.ConvertAll (seriesNum.Split ('-'), int.Parse);

            var increment = ( numberArray[0] < numberArray[1] ) ? 1 : -1;

            for ( int i = 0; i < numberArray.Length - 1; i++ )
            {
                
                if ( numberArray[i] + increment != numberArray[i + 1] )

                    return $"Your input {seriesNum} are not consecutive numbers.";

            }
            return $"Your input {seriesNum} are consecutive numbers.";

            //var uniqueSeries = new List<int> ();
            //var nums = Console.ReadLine ();
            //var seriesNum = nums.Split ('-');
            //Array.Sort (numberArray);

            //if ( string.IsNullOrEmpty (seriesNum) || string.IsNullOrWhiteSpace (seriesNum) )
            //{
            //    Console.WriteLine ("Invalid input"); 
            //    continue;
            //}

            //numberArray = Array.ConvertAll (seriesNum.Split ('-'), int.Parse);

            //increment = ( numberArray[0] < numberArray[1] ) ? 1 : -1;

            //if  (seriesNum.SequenceEqual(numberArray))
            //if (seriesNum = Array.Sort (numberArray);)
        }

        public static string DuplicateNumbers(string numSeries)
        {
            do
            {
                if ( string.IsNullOrEmpty (numSeries) || string.IsNullOrWhiteSpace (numSeries) )
                {
                    break;
                }

                else
                {
                    var arrayOfInput = Array.ConvertAll (numSeries.Split ('-'), int.Parse);

                    for ( int i = 0; i < arrayOfInput.Length - 1; i++ )
                    {
                        if ( Array.IndexOf (arrayOfInput, arrayOfInput[i], i + 1) != -1 )

                            return $"There is a duplicate of {arrayOfInput[i]} in the input. ";
                    }

                    return "There is no duplicate in the input";
                }

                //break;

            } while ( true );

            return " ";

            //return "Duplicate Numbers";
            
        }

        public static string TimeDeterminant(string timeValue)
        {
            //var dateTime = Convert.ToDateTime (timeValue);

            if ( string.IsNullOrWhiteSpace (timeValue) )
            {
                Console.WriteLine ("Invalid Input");

            }

            else
            {
                var hour = Convert.ToInt32 (timeValue.Split (':')[0]);
                var minute = Convert.ToInt32 (timeValue.Split (':')[1]);

                if ( ( hour > 0 & hour <= 23 ) && ( minute > 0 & minute <= 59 ) )
                    return $"Ok, the time value: {timeValue} is a valid 24 hours time input.";

                //else

            }

            return $"The time value input of {timeValue} is an \"Invalid Time\" ";

        }

        public static string PascalCase()
        {
            return "Duplicate Numbers";
            
        }

        public static string EnglishWord()
        {
            return "Duplicate Numbers";
        }
    }
}
