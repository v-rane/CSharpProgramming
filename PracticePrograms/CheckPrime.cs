using System;

/*
 * @auther name- varsha rane
 * @objective -program to check if the number is prime or not
 * @class name - CheckPrime
 * @date- 6-4-22
 */
namespace PracticePrograms
{   
 
    public class CheckPrime
    {
        // method objective -to check if number is prime or not
        //para - int number
        //return - boolean
        public bool isPrime(int number)
        {
            bool flag = true;
            if (number < 2)
            {
                flag= false;
            }
            else
            {

                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        flag = false;
                    }
                }

            }
            return flag;

        }
        
    }
}
