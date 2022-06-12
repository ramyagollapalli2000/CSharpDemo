using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleDemo
{
    public class Mobile
    {
        private int IMENo;
        public String Name;
        public void MyMobile()
        {
            IMENo = 456;
            Name = "Redmi";
            Console.WriteLine("My Mobile is :"+Name);
        }
        public int addition(int a, int b)
        {
            return a + b;
        }
        public int multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
