using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactView contactView = new ContactView();
            //hard coded contacts initializing.
            contactView.ContactViewMethod();
            //display selection for User.
            Display display = new Display();
            display.DisplayChoice();
            display.Selection();
        }
    }
}