using System;


namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            MyClass my2 = new MyClass();

            Console.ReadKey();

        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Simple constructor");
        } 
        static MyClass()
        {
            Console.WriteLine("Static constructor");
        }
    }
}
