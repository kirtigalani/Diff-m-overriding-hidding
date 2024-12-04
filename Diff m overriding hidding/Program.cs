using System;
using System.ComponentModel;

namespace Diff_m_overriding_hidding
{
    public class BaseClass
    {
        public virtual void print()
        {
            Console.WriteLine("I am Base class");
        }
    }
    public class derived : BaseClass
    {
        public new void print()
        {
            Console.WriteLine("I am Derive class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new derived();
            B.print();

            derived D = new derived();
            D.print();
        }
    }
}
