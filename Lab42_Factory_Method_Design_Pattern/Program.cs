using System;
using Lab42_Factory_Method_Design_Pattern.Classes;

namespace Lab42_Factory_Method_Design_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestDoc();
            Console.ReadLine();
        }

        public static void TestDoc()
        {
            Document doc = null;
            KinkosTheCreator kinkos = new KinkosTheCreator();
            doc = kinkos.OrderDocument("resume");

        }
    }
}
