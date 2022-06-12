using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileConnection obj=new MobileConnection();
            obj.MyCalls();
            obj.Dail();
            int num1 = 10;
            int num2 = 30;
            int num3 = num2 - num1;
            Console.WriteLine(num3);
            Mobile mobileObj=new Mobile();//object creation
            Console.WriteLine(mobileObj.addition(100,200));
            Console.WriteLine(mobileObj.multiplication(10, 5));
            mobileObj.MyMobile();//function calling using object 
            Console.WriteLine("Welcome");
           
            Console.Read();

        }
    }
}
