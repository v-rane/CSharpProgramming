using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    /*
     * @auther name - varsha rane
     * date- 6-4-22
     * @objective - to find the sum of the number
     * @class name - SumOfNumber
     */
    public class SumOfNumber
    {
        public int getSum(int number)
        {
            int sum=0;
           // if num is 0 then it will return 0 as sum
            if (number==0)
            {
               return 0;    
            }
            else
            {
                for(int i = 0;i <= number; i++)
                {
                    sum= sum+i;
                    //logic - add each number upto entered number from 0, so in sum variable it will be added. 
                }
            }
            return sum;
        }
    }
}
