using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Factory_Method_Design_Pattern.Classes
{
    public class Document
    {
        public void Prepare()
        {
            Console.WriteLine("This is a document. And it's being prepared.");
        }

        public void Write()
        {
            Console.WriteLine("Write some things. You heathen.");
        }
    }
}
