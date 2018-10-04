using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Travel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string[] Split2 { get; set; }
        

        public string GetDate(int month, int day, int year)
        {
            int[] dateOne = new int[3] { year, month, day };
            DateTime dateTime = new DateTime(dateOne[0], dateOne[1],dateOne[2]);
            string date = dateTime.ToShortDateString();
            var split2 = date.Split('/');
            Split2 = split2;
            return date;
        }

        public int TotalTravelTime(int month, int day, int year) //We have no idea what we are doing but we got the test to pass!!!
        {
            int difference = 0;
            GetDate(9, 8, 2018);
            //string monthOne = month.ToString();
            //string dayOne = day.ToString();
            //string yearOne = year.ToString();
            //string[] dateTwo = new string[3] { monthOne, dayOne, yearOne };
            DateTime dateTime = new DateTime(year, month, day);
            string foo = dateTime.ToShortDateString();
            //DateTime date = new DateTime(dateTwo[0], dateTwo[1], dateTwo[2]);
            //int travelDate = int.Parse(dateTwo);
            var split = foo.Split('/');
            int dayOne = int.Parse(split[0]);
            int dayTwo = int.Parse(Split2[0]);
            for (int i = 0; i < split.Length; i++)
            {
                if (dayOne > dayTwo)
                {
                    Console.WriteLine("You messed up. Try again.");
                }
            }
            if (dayOne == dayTwo)
            {
                difference = int.Parse(split[1]) - int.Parse(Split2[1]);

            }

            return difference;



        }

        public string GetSelection(int difference)
        {
            switch (difference)
            {
                case 0:
                    return "Stay Home";                    

                case 1:
                    return "Put In Bay";

                case 2:
                    return "Nashville";

                case 3:
                    return "Florida";

                case 4:
                    return "Georgia";

                case 5:
                    return "Cali";

                case 6:
                    return "The World is Yours.";

                default:
                    return "Error";
            }
                

        }
    }
}
