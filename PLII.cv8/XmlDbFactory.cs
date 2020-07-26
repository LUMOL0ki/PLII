using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv8
{
    public class XmlDbFactory : IContactDBFactory
    {
        public IContactDao CreateContactDao()
        {
            return new XmlContactDao();
        }
    }
}