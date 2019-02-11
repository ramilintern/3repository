using System;


namespace BoxingUnboxing
{
    struct BoxingUn
    {
        public void Method()
        {
            Console.WriteLine("Say Hello!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            BoxingUn box = new BoxingUn();
            object obj = box;

            BoxingUn box2 = (BoxingUn)obj;
            box2.Method();
           
            Console.ReadKey();
        }
    }
}
