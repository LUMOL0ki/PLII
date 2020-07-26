using PLII.cv7;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv8
{
    public interface IContactDao
    {
        void CreateContact(Contact c);
        void DeleteContact(Contact c);
        IEnumerable<Contact> FindAllContacts();
        void SaveContact(Contact c);
    }
}