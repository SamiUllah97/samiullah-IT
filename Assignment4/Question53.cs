using System;

namespace C_
{
    class Question53
    {
        static void Main(string[] args)

        {
            Console.WriteLine("\t\tQuestion#53"); 
            int x=20,y=35;
            x=y++ + x++;
            y= ++y + ++x;
            Console.Write("(a)  "+ x);
            Console.Write(y);

             // b
            int x = 10,y=15;
            x =  x++;
            y = ++y; 
            Console.Write("(b) " + x + ",");
            Console.Write(y); 

            //c

            int a=10;
            a++;
            Console.WriteLine("(c) "+a);

            //d
            int a = 10;
            Console.WriteLine("(d) "+ a++);

            //e
            int n =10;
            int x =0;
            x=n--;
            Console.WriteLine("(e) " +x);

           // f

            int i=5, j=6, k=7, n=3;

            Console.WriteLine(i+j*k%n);
            Console.WriteLine(i/n);

           // g

            int n;
            float x=3.8;
            n = int(x);
            Console.WriteLine("(g) " + " n= " + n);
            
           // h
            int a=6;
            Console.WriteLine("(h) "+ a);
            a=a+3;
            Console.WriteLine(a);
            a -=5;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);


        }
    }
}
