using System;

namespace Delegate1
{
    public delegate int AddDelegate(int a, int b);

    class Mathematics
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

    }



    class Programm
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            AddDelegate aD = new AddDelegate(m.Add);
        }
    
    }
}