using System;

namespace PhoneNumbers
{

    //Find the number of all valid(and different) phone numbers on a keyboard laid as follows:
    //A valid phone number is defined as:
    //• The bounce between consecutive digits has always to be a valid “Horse Chess-Move”, for
    //example 1 to 8 or 1 to 6, and so on…
    //• A phone number should not begin with 0
    //• A phone number has always 7 digits

    class Program
    {
        const int DIGITS = 9;

        static void Main(string[] args)
        {
            int totalNumbers = 0;
            for (int i = 1; i <= DIGITS; i++)
            {
                var rootNode = new PhoneNumberTree
                {
                    Node = i,
                    NodeDepth = 1
                };

                var calculator = new PhoneNumberCalculator();

                calculator.GetChildrenPhoneNumbersFor(rootNode);

                totalNumbers += calculator.GetTotal();
            }

            Console.WriteLine($"Total numbers: {totalNumbers}");

            Console.ReadLine();
        }
    }
}
