using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Factory_Method_Design_Pattern.Classes
{
    public abstract class DocumentStore
    {
        protected abstract Document CreateDocument(string type);

        public Document OrderDocument(string type)
        {
            Document doc = CreateDocument(type);

            doc.Prepare();
            doc.Write();

            return doc;
        }
    }
}
