using System;

namespace C_
{
    class Question61
    {
        static void Main(string[] args)

        {

            Console.WriteLine("\t\t\t Question 61");

            int a,b,c,d,e;
            a=10;
            b=20;
            c=15;
            d=8;
            e=40;

            Console.WriteLine("(1) "+(a+b/(c-5))/((d+7)/(e-37)%3));
            Console.WriteLine("(2) "+ (a+b/c-5/d+7/e-37%3));
            Console.WriteLine("(3) "+ (a*(b*b)-(c*b)+d));
        }
    }
}
