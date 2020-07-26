using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv8
{
    public interface IContactDBFactory
    {
        IContactDao CreateContactDao();
    }
}