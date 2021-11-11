using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemsTest
{
    public class TestingClass
    {
        public string message;
        public TestingClass(string message)
        {
            this.message = message;

        }
        //We are using this method to match pattern of first name
        public string validFirstName()
        {
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";  //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(message))
            {
               // Console.WriteLine(message + "-->Valid");
                return "Valid";
            }
            else
            {
                //Console.WriteLine(message + "--->Invalid");
                return "Invalid";
            }
        }
        //We are using this method to match pattern of last name
        public string LastName(string name)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(name))
            {
                //Console.WriteLine(name + "-->Valid");
                return "Valid";
            }
            else
            {
               // Console.WriteLine(name + "--->Invalid");
                return "Invalid";
            }
        }

        //This method for validation of email id
        public string ValidEmail(string mail)
        {
            string emailid = "^[a-z]{3}[.][a-z0-9]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; //Expression for gmail format
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(mail))
            {
                //Console.WriteLine(mail + "-- > Valid");
                return "Valid";
            }
            else
            {
                //Console.WriteLine(mail + "-- > InValid");
                return "Invalid";
            }

        }

        //We are using this method to match pattern of mobile no
        public static void mobileFormat(string number)
        {
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";  //Expression for Validating mobileFormating
            Regex regex = new Regex(Mobnumber);

            if (regex.IsMatch(number))
            {
                Console.WriteLine(number + "-- > Valid");
            }
            else
            {
                Console.WriteLine(number + "-- > InValid");
            }

        }


        //We are using this method to match pattern of password format
        public static void passwordFormat(string pass)
        {
            string pwd = "^[a-zA-Z0-9]{8,}$";
            Regex regex = new Regex(pwd);        //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + "-- > Valid");
            }
            else
                Console.WriteLine(pass + "-- > InValid");
        }

        //We are using this method to match pattern of Upper Case Password format
        public static void UpperCaseFormat(string pass)
        {
            string pwd = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$"; //creating a regex named obj with regular pwd.
            Regex regex = new Regex(pwd);
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + "-- > Valid");
            }
            else
            {
                Console.WriteLine(pass + "-- > InValid");
            }
        }
    }
}



