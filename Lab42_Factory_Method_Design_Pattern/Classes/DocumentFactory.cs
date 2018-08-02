using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Factory_Method_Design_Pattern.Classes
{
    class DocumentFactory
    {
        public static Document CreateDocument(string documentType)
        {
            Document doc = null;
            switch (documentType.ToLower())
            {
                case "coverletter":
                    doc = new CoverLetter();
                    break;
                case "resume":
                    doc = new Resume();
                    break;
                default:
                    break;
            }
            return doc;

        }
    }
}
