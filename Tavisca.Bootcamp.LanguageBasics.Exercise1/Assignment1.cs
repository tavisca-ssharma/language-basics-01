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
            string first_num = equation.Split('*')[0];
            string second_num = equation.Split('*')[1].Split('=')[0];
            string result = equation.Split('=')[1];

            bool ques_in_first = Int32.TryParse(first_num, out int int_firstnum);
            bool ques_in_second = Int32.TryParse(second_num, out int int_secondnum);
            bool ques_in_result = Int32.TryParse(result, out int int_result);

            
            string newEquation = "";

            if(ques_in_first == false)
            {
                if(int_result % int_secondnum==0)
                {                              
                    string temp = (int_result / int_secondnum) + "";
                    newEquation += temp + "*" + second_num + "=" + result;
                }
                else 
                    return -1;
            }

            if(ques_in_second == false)
            {
                if(int_result % int_firstnum == 0)
                {
                string temp = (int_result / int_firstnum) + "";
                newEquation += first_num + "*" + temp + "=" + result;
                }
                else
                    return -1;
            }

            if(ques_in_third == false)
            {
                string temp = (int_firstnum * int_secondnum) + "";
                newEquation += first_num + "*" + second_num + "=" + temp;
            }

            if (equation.Length != newEquation.Length)
            {
                return -1;
	        }
            else
            {
                for (int i = 0; i < newEquation.Length; i++)
			    {
                    if(newEquation[i] != equation[i] && equation[i]=='?')
                        return (int)(newEquation[i] - '0');
			    }
            }
            throw new NotImplementedException();
        }
    }
}