using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PLII.cv7
{
    public class ContactEnum : IEnumerator<Contact>
    {
        private int position = -1;

        public ContactEnum(IList<Contact> contacts)
        {
            Contacts = contacts;
        }

        public IList<Contact> Contacts
        {
            get;
        }

        public Contact Current
        {
            get
            {
                try
                {
                    return Contacts[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            Contacts.Clear();
        }

        public bool MoveNext()
        {
            position++;
            return (position < Contacts.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
