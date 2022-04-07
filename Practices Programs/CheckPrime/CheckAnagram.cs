using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * @auther name - varsha rane
 * @ date - 6-4-22
 * @objective - program to check if the string is anagram or not.
 * @class name - CheckAnagram
 */
namespace PracticePrograms
{
    public class CheckAnagram
    {
        public bool areAnagram(String firstString, String secondString)
        { 
            // if any or both the strings are null
            if (firstString == null || secondString == null)
            {
                return false;
            }
            //if the length of the strings are not equal
            else if (firstString.Length != secondString.Length)
            {
                return false;
            }
            //if the length of both the strings are equals
            else if(firstString.Length == secondString.Length)
            {
                // to convert both the strings into charArray and then also converting it into lowercase
                char[] firstStringArray = firstString.ToLower().ToCharArray();
                char[] secondStringArray = secondString.ToLower().ToCharArray();

                // to sort both arrays 
                Array.Sort(firstStringArray);
                Array.Sort(secondStringArray);
                for (int i = 0; i < firstStringArray.Length; i++)
                {
                    if (firstStringArray[i] != secondStringArray[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}