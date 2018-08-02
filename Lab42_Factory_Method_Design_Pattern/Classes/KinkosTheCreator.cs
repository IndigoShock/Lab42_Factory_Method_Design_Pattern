using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Factory_Method_Design_Pattern.Classes
{
    public class KinkosTheCreator: DocumentStore
    {
        protected override Document CreateDocument(string type)
        {
            Console.WriteLine("You could either get a resume or cover letter. One is more dead than the other.");

            return DocumentFactory.CreateDocument(type);
        }

    }
}
