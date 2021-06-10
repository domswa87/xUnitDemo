using System;

namespace Methods
{
    public class Methods
    {

        public static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public static string AddNumbersWithText(int number1, int number2, string text)
        {                                       
            return text + number1 + number2;                
        }

        public static int DivideNumbers(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
