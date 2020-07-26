using System;
using System.Collections.Generic;

namespace PLII.cv7.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacts contacts = new Contacts();
            contacts.Add(new Contact()
            {
                Name = "Franta",
                Age = 22,
                Email = "F@a.com",
                Weight = 90,
                IsAlive = true
            });
            contacts.Add(new Contact()
            {
                Name = "Maruna",
                Age = 24,
                Email = "M@a.com",
                Weight = 75,
                IsAlive = true
            });
            contacts.SaveToFile("Contacts.txt"); 
            contacts.SaveToBinaryFile("Contacts.dat");
            Contacts loadedContacts = new Contacts(Contacts.LoadFromFile("Contacts.txt"));
            Contacts binary = new Contacts(Contacts.LoadFromBinaryFile("Contacts.dat"));
            foreach(Contact contact in binary)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
