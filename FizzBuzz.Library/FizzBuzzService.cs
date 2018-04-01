using System;
using System.Collections.Generic;
namespace FizzBuzz.Library
{    
    public class FizzBuzzService    
    {        
        public string Print(int number)
        {
            if (number % 3 == 0)
            {
                if (number % 5 == 0) {
                    return "FizzBuzz";
                }
                return "Fizz";
            }

            else if (number % 5 == 0) 
            {
                return "Buzz";
            }
            else {
                return number.ToString();
            }

        }        
    }
}