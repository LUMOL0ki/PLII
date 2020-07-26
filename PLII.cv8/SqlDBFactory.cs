using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv8
{
    public class SqlDBFactory : IContactDBFactory
    {
        public IContactDao CreateContactDao()
        {
            return new SqlContactDao();
        }
    }
}