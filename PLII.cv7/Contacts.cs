using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PLII.cv7
{
    public class Contacts : IList<Contact>
    {
        private IList<Contact> contacts;

        public int Count => contacts.Count;

        public bool IsReadOnly => contacts.IsReadOnly;

        Contact IList<Contact>.this[int index] { get => contacts[index]; set => contacts[index] = value; }

        public Contacts()
        {
            this.contacts = new List<Contact>();
        }

        public Contacts(IList<Contact> contacts)
        {
            this.contacts = contacts;
        }
        
        public void SaveToFile(string nameOfFile)
        {
            List<string> lines = new List<string>();

            foreach (Contact contact in contacts)
            {
                lines.Add(contact.ToString());
            }

            FileManager.SaveToFile(nameOfFile, lines);
        }

        public void SaveToBinaryFile(string nameOfFile)
        {
            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(nameOfFile)))
            {
                foreach (Contact contact in contacts)
                {
                    writer.Write(contact.Name);
                    writer.Write(contact.Age);
                    writer.Write(contact.Email);
                    writer.Write((double)contact.Weight);
                    writer.Write(contact.IsAlive);
                }
            }
        }

        public static IList<Contact> LoadFromBinaryFile(string nameOfFile)
        {
            IList<Contact> tempContacts = new Contacts();
            using (BinaryReader reader = new BinaryReader(File.OpenRead(nameOfFile)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    tempContacts.Add(
                        new Contact()
                        {
                            Name = reader.ReadString(),
                            Age = reader.ReadInt32(),
                            Email = reader.ReadString(),
                            Weight = (float)reader.ReadDouble(),
                            IsAlive = reader.ReadBoolean()
                        });
                }
            }
            return tempContacts;
        }

        public static IList<Contact> LoadFromFile(string nameOfFile)
        {
            List<string> lines = FileManager.LoadFromFile(nameOfFile);
            IList<Contact> contacts = new Contacts();
            foreach(string line in lines)
            {
                string[] data = line.Split(';');
                contacts.Add(
                    new Contact()
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        Email = data[2],
                        Weight = int.Parse(data[3]),
                        IsAlive = bool.Parse(data[4])
                    }
                    );
            }
            return contacts;
        }

        public IEnumerator<Contact> GetEnumerator()
        {
            return new ContactEnum(contacts);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Contact item)
        {
            contacts.Add(item);
        }

        public void Clear()
        {
            contacts.Clear();
        }

        public bool Contains(Contact item)
        {
            return contacts.Contains(item);
        }

        public void CopyTo(Contact[] array, int arrayIndex)
        {
            contacts.CopyTo(array, arrayIndex);
        }

        public bool Remove(Contact item)
        {
            return contacts.Remove(item);
        }

        public int IndexOf(Contact item)
        {
            return contacts.IndexOf(item);
        }

        public void Insert(int index, Contact item)
        {
            contacts.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            contacts.RemoveAt(index);
        }
    }
}
