using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * @auther name -varsha rane
 * @date - 7-4-22
 * objective - to execute all programs in form of choices that we will enter
 */
namespace PracticePrograms
{
    internal class Execution
    {
        static void Main(string[] args)
        {   
            //from switch case we will enter the choice which program we will execute
            Console.WriteLine("list of given cases");
            Console.WriteLine("1. check prime number ");
            Console.WriteLine("2. check if the strings are anagram or not ");
            Console.WriteLine("3. reverse the string ");
            Console.WriteLine("4. find the factorial of number ");
            Console.WriteLine("5. sum of n numbers ");
            Console.WriteLine("6.Two sum ");
            Console.WriteLine("7. check number is even or odd ");
            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice) {

                //CheckPrime program = new CheckPrime();
                case 1:

                    CheckPrime checkPrime = new CheckPrime();
                    Console.WriteLine("Enter the number:");
                    int number = int.Parse(Console.ReadLine());
                    if (checkPrime.isPrime(number))
                     {
                         Console.WriteLine("yes, the number is prime :" + number);
                     }
                     else
                     {
                        Console.WriteLine("No ,the number is not prime:" + number);
                     }
                    break;


                //2. anagram execution
                case 2:
                     String firstString =null, secondString= null;
                    Console.WriteLine("Enter the first string to be checked");
                    firstString = Console.ReadLine();
                    Console.WriteLine("Enter the second string to be checked");
                    secondString = Console.ReadLine();
                    CheckAnagram checkAnagram = new CheckAnagram();
                    if (checkAnagram.areAnagram(firstString, secondString))
                    {
                        Console.WriteLine("yes ,both the strings  " + firstString + "and " + secondString + " are anagram");
                    }
                    else
                    {
                       Console.WriteLine("No ,both the strings " + firstString + "and " + secondString + " are anagram");

                    }
                    break;


                //3.reverse the string 
                case 3:
                    String name;
                    String reverse ="";
                    Console.WriteLine("Enter the first string to be reversed");
                    name = Console.ReadLine();
                    ReverseString reverseString = new ReverseString();
                    reverse += reverseString.getReversedString(name);
                    Console.WriteLine("the reversed string is" + reverse);
                    break;


                //4.factorial of number
                case 4:
                    int number1;
                    Console.Write("Enter any Number: ");
                    number1 = int.Parse(Console.ReadLine());
                    FactorialOfNumber factorialOfNumber = new FactorialOfNumber();
                    int result = factorialOfNumber.getFactorial(number1);
                    Console.Write("Factorial of " + number1 + " is: " + result);
                    break;


                //5.sum of n numbers
                case 5:
                    Console.WriteLine("enter a number");
                    int number2 =int.Parse(Console.ReadLine());
                    SumOfNumber sumOfNumber = new SumOfNumber();
                    Console.WriteLine(sumOfNumber.getSum(number2));
                    break;


                //6.TwoSum
                case 6:
                    //Console.WriteLine("enter the elements in array");
                    //int[] array = new int[5];
                    // for (int i = 0; i < array.Length; i++)
                    // {
                    //     array[i] = int.Parse(Console.ReadLine());
                    // }
                    // Console.WriteLine("enter the target value");
                    // int target = int.Parse(Console.ReadLine());

                     //TwoSum twoSum = new TwoSum();
                    //  logic 1
                    //bool result2 = twoSum.getTwoSum(array, target);
                    //Console.WriteLine(result2);

                    // logic 2
                    Console.WriteLine("enter size of array");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the elements in array");
                    int[] array2 = new int[n];
                    for (int i = 0; i < array2.Length; i++)
                    {
                        array2[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("enter the target value");
                    int target2 = int.Parse(Console.ReadLine());

                    TwoSum twoSum = new TwoSum();
                    int[] res= twoSum.getTwoSum(array2,target2,n);
                    Console.WriteLine("the array elements "+ res[0]+ " + "+ res[1]+ " "+ " = "+ target2);
                    break;


                case 7:
                    Console.WriteLine("enter a number to be checked if even or odd");
                   int number3 =  int.Parse(Console.ReadLine());
                    CheckEven checkEven = new CheckEven();
                    if (checkEven.getEven(number3))
                    {
                        Console.WriteLine("yes, the number is even:"+ number3);
                    }
                    else
                    {
                        Console.WriteLine("no the number is odd:" + number3);
                    }

                    break;

            }
        }
    }

    
}
