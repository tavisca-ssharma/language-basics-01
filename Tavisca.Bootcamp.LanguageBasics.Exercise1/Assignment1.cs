using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {     
	    string[] numbers = equation.Split(new char[] { '*', '=' });
            string firstnum = numbers[0];
            string secondnum = numbers[1];
            string result = numbers[2];

            if(firstnum.Contains('?'))
            {
		int c = int.Parse(result);
		int b = int.Parse(secondnum);
                if(c % b==0)
                {                              
                    string temp = (c / b) + "";
		    if(temp.Length == firstnum.Length)
		    {
		       int index = firstnum.indexOf('?');
		       return (int)(temp[index] - '0');
		    }
		    else
		       return -1;
                }
                else 
                    return -1;
            }

            if(secondnum.Contains('?'))
            {
		int c = int.Parse(result);
		int a = int.Parse(firstnum);
                if(c % a == 0)
                {
                    string temp = (c / a) + "";
                    if(temp.Length == secondnum.Length)
		    {
		       int index = secondnum.indexOf('?');
		       return (int)(temp[index] - '0');
		    }
		    else
		       return -1;
                }
                else
                    return -1;
            }

            if(result.Contains('?'))
            {
		int a = int.Parse(firstnum);
		int b = int.Parse(secondnum);
                string temp = (a * b) + "";
                if(temp.Length == result.Length)
		{
		    int index = result.indexOf('?');
		    return (int)(temp[index] - '0');
		}
		else
		    return -1;
            }
        }
    }
}
