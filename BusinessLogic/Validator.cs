using System;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            //Replaces all dashes with nothing.
            ssn = ssn.Replace("-", string.Empty);

            if (ssn.Length != 9)
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if (numToTest < minValue || numToTest > maxValue)
            {
                return false;
            }
            else
                return true;
        }
    }
}
