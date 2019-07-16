using System;
using System.Collections.Generic;

namespace TryCatch
{
    public class AddressBook
    {
        public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact name)
        {
            contacts.Add(name.Email, name);

        }

        public Contact GetByEmail(string email)
        {
            try
            {
                Contact returnContact = contacts[email];
                return returnContact;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

        }
    }
}