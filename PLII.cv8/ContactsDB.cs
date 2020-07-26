using PLII.cv7;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv8
{
    public class ContactsDB
    {
        private IContactDBFactory db;

        public ContactsDB(IContactDBFactory dBFactory)
        {
            this.db = dBFactory;
        }

        public void SaveContact(Contact c)
        {
            IContactDao contactDao = this.db.CreateContactDao();
            contactDao.CreateContact(c);
        }

        public IEnumerable<Contact> FindAllContacts()
        {
            IContactDao contactDao = this.db.CreateContactDao();
            return contactDao.FindAllContacts();
        }
    }
}