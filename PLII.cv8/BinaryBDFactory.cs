using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv8
{
    public class BinaryBDFactory : IContactDBFactory
    {
        public IContactDao CreateContactDao()
        {
            return new BinaryContactDao();
        }
    }
}