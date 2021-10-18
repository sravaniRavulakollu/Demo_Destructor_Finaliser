using System;
using Demo_Destructer_Finalizer;



namespace Demo_Destructer_Finalizer
{
    class Program : MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Finalizer!");
            MyClass obj1 = new MyClass();
            obj1.Display_Msg();



            //MyClass obj2 = new MyClass("Secret msg");
            //obj2.Display_Msg();



            obj1.Dipose();



        }
    }
}