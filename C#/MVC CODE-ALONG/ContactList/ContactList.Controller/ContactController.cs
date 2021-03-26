using ContactList.Data;
using ContactList.Models;
using ContactList.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Controller
{
    public class ContactController
    {
        private UserInterface userInterface;
        private ContactRepository repository;

        public ContactController()
        {
            userInterface = new UserInterface();
            repository = new ContactRepository();
        }
        public void Run()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                int menuChoice = userInterface.ShowMenuAndGetUserChoice();

                switch (menuChoice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        //Do Something
                        break;
                    case 3:
                        //Do Something 
                        break;
                    case 4:
                        //Do Something
                        break;
                    case 5:
                        //Do Something 
                        break;
                    case 6:
                        //Exit Application
                        keepRunning = false;
                        break;
                }
            }
        }
        private void AddContact()
        {
            // ContactController newContact = userInterface.GetNewContactInformation();
            Contact newContact = userInterface.GetNewContactInformation();
            // ContactController addedContact = repository.CreateContact(newContact);
            Contact addedContact = repository.CreateContact(newContact);


            if (addedContact != null)//Successfully added to repository
            {
                //Show the new contact, including the ID that came from the respository
                userInterface.DisplayContact(addedContact);
                userInterface.ShowActionSuccess("Add Contact");
            }
            else//Failed to add to repository
            {
                userInterface.ShowActionFailure("Add Contact");
            }
        }
    }
}
