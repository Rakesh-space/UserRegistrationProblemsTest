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
    }
}
