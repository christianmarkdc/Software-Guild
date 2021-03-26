using ContactList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.BLL
{
    public class ContactManager
    {
        Data.ContactRepository repo;

        public ContactManager()
        {
            repo = new Data.ContactRepository();
        }
    }
    public Contact AddContact(Contact contact)
    {
        if(contact.ContactID < 0)
        {
            throw new Exception("ID cannot be less than 0.");
        }
        if (String.IsNullOrEmpty(contact.FirstName))
        {
            throw new Exception("First Name cannot be empty.");
        }
        if (String.IsNullOrEmpty(contact.LastName))
        {
            throw new Exception("Last Name cannot be empty.");
        }
        if (String.IsNullOrEmpty(contact.Email))
        {
            throw new Exception("Email cannot be empty.");
        }
        //Only calling this line after all validation has been done.
        return repo.CreateContact(contact);
    }
}
