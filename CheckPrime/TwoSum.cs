using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class TwoSum
    {
        //logic 1 
        //public bool getTwoSum(int[] array,int target)
        //{
        //    bool flag = false; 
        //    //for loop for iterating array from 1st element to last 
        //    for(int i = 0; i < array.Length; i++)
        //    {   
        //        //for loop for iterating array from 2nd element to last
        //        for(int j = i + 1; j<array.Length; j++)
        //        {
        //            //if for comparing 1st element + next element and then comparing with target if sum is equal then true else false 
        //            if (array[i]+ array[j]== target)
        //            {
        //                flag = true;
        //            }
        //            else
        //            {
        //                flag = false;
        //            }
        //        }
                
        //    }
        //    return flag;
        //}

        //logic 2
        public int[] getTwoSum(int[] array,int target, int n)
        {
            int[] result = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[i]+ array[j] == target)
                    {
                        result[0]= array[i];
                        result[1]= array[j];
                    }
                }
            }
            return result;
        }
    }
}
