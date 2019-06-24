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
            int len = equation.length();
            char[] val = sentence.ToCharArray();
            int i,j=0,k=0,l=0,asum=0,bsum=0,csum=0,fin=0,countr,q,ques,mul,eql;
            for(i=0;i<len;i++)
            {
                if(val[i]=='?')
                    {
                        ques = i;
                    }
                if(val[i]=='=')
                    {
                        eql = i;
                    }
                if(val[i]=='*')
                    {
                        mul = i;
                    }
            }
            var c = new char[len-eql];
            var a = new char[mul];
            var b = new char[eql-mul];
            for(i=eql+1;i<len;i++)
            {
                c[j++]=val[i];
                if(val[i]=='?')
                    {
                        her = j;
                    }
            }
            for(i=mul+1;i<eql;i++)
            {
                b[k++]=val[i];
                if(val[i]=='?')
                    {
                        her = k;
                    }
            }
            for(i=0;i<mul;i++)
            {
                a[l++]=val[i];
                if(val[i]=='?')
                    {
                        her = l;
                    }
            }
            if(ques<mul)
            {
                for(i=k-1;i>=0;i--)
                {
                    bsum = bsum + pow(10,i)*b[i];
                }
                for(i=l-1;i>=0;i--)
                {
                    csum = csum + pow(10,i)*c[i];
                }
                fin = csum/bsum;
                for(i=0;i<=9;i++)
                {
                    countr=0;
                    a[her]=i;
                    for(q=0;q<l;q++)
                    {
                        countr = countr + pow(10,l-q)*a[q];
                    }
                    if(countr==fin)
                    {
                        return i;
                        break;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            else if(ques<eql && ques>mul)
            {
                for(i=k-1;i>=0;i--)
                {
                    asum = asum + pow(10,i)*a[i];
                }
                for(i=l-1;i>=0;i--)
                {
                    csum = csum + pow(10,i)*c[i];
                }
                fin = csum/asum;
                for(i=0;i<=9;i++)
                {
                    countr=0;
                    b[her]=i;
                    for(q=0;q<k;q++)
                    {
                        countr = countr + pow(10,k-q)*b[q];
                    }
                    if(countr==fin)
                    {
                        return i;
                        break;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            else
            {
                for(i=k-1;i>=0;i--)
                {
                    asum = asum + pow(10,i)*a[i];
                }
                for(i=l-1;i>=0;i--)
                {
                    bsum = bsum + pow(10,i)*b[i];
                }
                fin = asum*bsum;
                for(i=0;i<=9;i++)
                {
                    countr=0;
                    c[her]=i;
                    for(q=0;q<j;q++)
                    {
                        countr = countr + pow(10,j-q)*c[q];
                    }
                    if(countr==fin)
                    {
                        return i;
                        break;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            throw new NotImplementedException();
        }
    }
}