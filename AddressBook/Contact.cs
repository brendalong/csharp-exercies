using System;

namespace Book
{
  // Define class here
  public class Contact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public string FullName
    {
      get
      {
        return $"{FirstName} {LastName}";
      }
    }

  }

}

/*
FirstName = "Bob",
LastName = "Smith",
Email = "bob.smith@email.com",
Address = "100 Some Ln, Testville, TN 11111"
*/
