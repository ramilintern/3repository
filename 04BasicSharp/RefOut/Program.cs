using System;



namespace _04BasicSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref and out parametrs

            int x; //can not initialize 
            Sum(15, 5, out x);

            Console.WriteLine(x);
            
            string y = "Hello +";
            AddString(ref y);

            Console.WriteLine(y);
            Console.ReadKey();
        }
        static void Sum(int a,int b, out int c)
        {
            c= a + b; //must be initialize
        }
        static void AddString(ref string str1)
        {
            string str2=" World!";

            str1 += str2;
        }
    }
}
