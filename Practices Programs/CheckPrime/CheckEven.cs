using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class CheckEven
    {
        public bool getEven(int number)
        {  
            bool flag =false;
            if (number %2== 0)
            {
                flag=true;
            }
            else
            {
                flag=false;
            }
             return flag;
        }
    }
}
