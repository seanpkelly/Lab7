using System;
using System.Text.RegularExpressions;

namespace Lab7_Reg_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            while (x)
            {
                Console.WriteLine("Please insert your name here: ");
                string nameInput = Console.ReadLine();
                bool name = ValidateName(nameInput);
                while (!name)
                {
                    Console.WriteLine("try again!");
                    name = ValidateName(Console.ReadLine());
                    //ValidateName(name1);
                }

                Console.WriteLine("Please insert your email");
                string emailInput = Console.ReadLine();
                ValidateEmail(emailInput);


                Console.WriteLine("Please insert your phone number");
                string phoneInput = Console.ReadLine();
                IsPhoneNumber(phoneInput);


                Console.WriteLine("Please insert the date in mm/dd/yyyy format.");
                string dateInput = Console.ReadLine();
                //ValidateDate(dateInput);


                Console.WriteLine("Try again? y/n");
                string answer = Console.ReadLine();
                while (answer == "y")
                {
                    break;
                }
                while (answer == "n")
                {
                    Console.WriteLine("Thanks, take care!");
                    x = false;
                    break;
                }

            }


        }
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
        private bool ValidateDate(string date)
        {
            try
            {
                DateTime testDate = new
                    DateTime(Convert.ToInt32(date[2]),
                    Convert.ToInt32(date[0]),
                    Convert.ToInt32(date[1]));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidateName(string name)
        {


            if (Regex.IsMatch(name, @"([A-Z][a-z]){1,30}\w"))
            {
                Console.WriteLine("that works!");
                return true;
            }
            else
            {
                Console.WriteLine("no, I'm sorry, try again");
                return false;
            }
            // else
            // {
            //   Console.WriteLine("Invalid. Name must start with a capital letter, try again!");
            //return false;
        }




        public static bool ValidateEmail(string name)
        {


            if (Regex.IsMatch(name, @"^([\w 0-9]{5,30})*@((([\-\w]{5,10}\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {
                Console.WriteLine("Great job");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry that's not correct, you messed up");
                return false;
            }
        }
    }
}
    


