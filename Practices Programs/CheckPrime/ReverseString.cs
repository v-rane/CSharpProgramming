using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    /*
     * @auther name - varsha rane
     * @objective - to get reversed string 
     * date - 6-4-22
     */ 
    internal class ReverseString
    {
        //para - string name
        public string getReversedString(String name)
        {
            //if the string is null it will return null
            String revString = "";
            if (name == null)
            {
                return name;
            }
            else
            {
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    revString = revString + name[i];
                }
            }
            return revString;
        }
    }
}
