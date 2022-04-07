using System;

namespace Delegate3
{
    public delegate void MyDelegate();
    
    class Program
    { 
        private static void Method1()
        {
            Console.WriteLine("Method1");
        }

        private static void Method2()
        {
            Console.WriteLine("Method2");
        }

        private static void Method3()
        {
            Console.WriteLine("Method3");
        }

        static void Main (string [] args)
        {
            MyDelegate mD = null;

            MyDelegate mD1 = new MyDelegate(Method1);

            MyDelegate mD2 = new MyDelegate(Method2);

            MyDelegate mD3 = new MyDelegate(Method3);

            mD = mD1 + mD2 + mD3;

            mD();

            Console.WriteLine("Введите число от 1 до 7");

            int res = int.Parse(Console.ReadLine());

            Console.Readkey();
        }









    }



}
