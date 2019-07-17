using System;
using System.Collections.Generic;

namespace TryCatch
{
    public class AddressBook
    {
        public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact.Email, contact);

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