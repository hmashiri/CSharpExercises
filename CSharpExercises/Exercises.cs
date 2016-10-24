﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")

        public static string SayHello(string name)
        {
            return ($"Hello {name}!");
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.

        public static int Sum(int a, int b)
        {
            return (a + b);
        }

        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.

        public static float Divide(float a, float b)
        {
            return (a / b);
        }

        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.

        public static Boolean CanOpenCheckingAccount(int age)
        {
            if (age >= 18) { return true; }
            else { return false; }
        }

        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.

        public static string GetFirstName(string StringInput)
        {
            var GetFirstStringWord = StringInput.Substring(0, StringInput.IndexOf(" "));
            return GetFirstStringWord;
        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)

        public static string ReverseStringHard(string ReverseString)
        {
            string output = "";
            int index = 0;
            index = ReverseString.Length - 1;
            while (index >= 0)
            {
                output += ReverseString[index]; index--;
            }
            return output;
        }

        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)

        public static string ReverseStringEasy(string ReverseString)
        {
            char[] charArray = ReverseString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */

        public static string PrintTimesTable(int NumberInput)
        {
            // var returnString = "";
            var products = 0;
            string TimesTablePrint = "";
            for (var i = 1; i < 10; i++)
            {
                products = NumberInput * i;
                TimesTablePrint += NumberInput + " * " + i + " = " + products + "\r\n";
            }

            TimesTablePrint += NumberInput + " * " + 10 + " = " + (NumberInput * 10);
            return TimesTablePrint;

        }



        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.

        public static double ConvertKelvinToFahrenheit(double KelvinTemp)
        {
            double FahrenheitTemp = (9d / 5d * (KelvinTemp - 273.15d) + 32d);
            return FahrenheitTemp = Math.Round(FahrenheitTemp, 2);
        }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        
        public static double GetAverageHard(int[] integers)
        {
            
            double results = 0;
            double average = 0;

           for (var i = 0; i < integers.Length; i++)
            {
                results += integers[i];
            }

            average = results / integers.Length;
            return average;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)

        public static double GetAverageEasy(int[] integers)
        {
            double AvgValue = integers.Average();
            Console.WriteLine(AvgValue);
            return AvgValue;
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888  
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
        public static string DrawTriangle(int number, int width)
        {
            string Triangle = "";
            for (var i = width; i >= 0; i--)
            {
                for (var j = i; j >= 1; j--)
                {
                    Triangle += number.ToString();
                }
                if (i >= 2)
                {
                    Triangle += System.Environment.NewLine;
                }
            }

            return Triangle;
        }


        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")

        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            string speedMPH;
            double calSpeed;
            float MinsInHour = (float)minutes / 60;
            float SecsInHour = (float)seconds / 3600;
            float TotalTime = hours + MinsInHour + SecsInHour;
            calSpeed = Math.Round(distance / TotalTime);
            speedMPH = Convert.ToString(calSpeed);
            return speedMPH + "MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static Boolean IsVowel(char CharacterInput)
        {
            Boolean isVowel = "aeiouAEIOU".IndexOf(CharacterInput) >= 0;
            return isVowel;
        }
        
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static Boolean IsConsonant(char CharacterInput)
        {
            Boolean IsConsonant = "aeiouAEIOU".IndexOf(CharacterInput) < 0;
            return IsConsonant;
        }
        
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.

       public static int CollatzConjecture(int integer)
        {
            int NumberOfSteps = 0;

            while (integer > 1)
            {
                if (integer % 2 == 0)
                {
                    integer = integer / 2;
                    NumberOfSteps++;
                }

                else
                { 
                    integer = (3 * integer) + 1;
                    NumberOfSteps++;
                }
            }
            return NumberOfSteps;
        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).

        public static DateTime[] GetNext7Days(DateTime date)
        {

            DateTime[] next7Days = new DateTime[7];

            for (int i = 0; i < 7; i++)
            {
                next7Days[i] = date.AddDays(i);
            }
            return next7Days;
        }

        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
       public static Boolean IsInLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double LoanBalance, double InterestRate, int LoanTermInYears, int PaymentPeriod)
        {
            double mortgagePayment = 0;
            double x = 0;
            double YearlyInterestRatep = InterestRate / 100;
            double monthlyInterestRatep = YearlyInterestRatep / 12;
            int monthsOfPaymentOverTerm = LoanTermInYears * PaymentPeriod;

            x = Math.Pow((1 + monthlyInterestRatep), monthsOfPaymentOverTerm);

            mortgagePayment = (LoanBalance * YearlyInterestRatep * x) / (12 * (x - 1));
            return Math.Round(mortgagePayment, 2);
    }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */
        public static string DuckGoose(int n)
        {
            string x = "";
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    x += "DuckGoose";
                }
                else if (i % 3 == 0)
                {
                    x += "Duck";
                }
                else if (i % 5 == 0)
                {
                    x += "Goose";
                }
                else
                {
                    x += i;
                }
                if (i < n)
                {
                    x += Environment.NewLine;
                }
            }
            return x;
        }
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}