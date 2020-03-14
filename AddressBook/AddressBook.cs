using System;
using System.Collections.Generic;

namespace Book
{
  // Define class here
  public class AddressBook
  {

    public Dictionary<string, Contact> allContacts { get; set; }




    public AddressBook()
    {
      allContacts = new Dictionary<string, Contact>();
    }

    public void AddContact(Contact contact)
    {
      allContacts.Add(contact.Email, contact);
    }

    public Contact GetByEmail(string email)
    {
      return allContacts[email];
    }

  }

}