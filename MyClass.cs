using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Demo_Destructer_Finalizer
{
    class MyClass
    {
        public void Display_Msg()
        {
            Console.WriteLine("Inside Display Method");
        }
        public MyClass()
        {
            Console.WriteLine("Default constructer...");
        }
        public MyClass(string msg)
        {
            Console.WriteLine("Parametrised constructor with a message {0}", msg);
        }
        //~MyClass()
        //{
        // Console.WriteLine("Freeing up Resources...");
        //}

        public void Dipose()
        {
            Console.WriteLine("Freeing up resources");
            GC.SuppressFinalize(this);



        }
    }
}