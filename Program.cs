using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            Contacts contacts = new Contacts
            {
                FirstName = "Kalpana",
                LastName = "",
                Address = "Ags",
                City = "Bellary",
                State = "Karnataka",
                ZipCode = 583114,
                PhoneNumber = 1234567890,
                Email = "kalpanag808@gmail.com"
            };
            contacts.ValidateContactDetails();           
            Console.WriteLine("Contact Details: ");
            Console.WriteLine($"Full Name: {contacts.FirstName + contacts.LastName} ");
            Console.WriteLine($"Phone Number: {contacts.PhoneNumber} ");
            Console.WriteLine($"Address: {contacts.Address} \n \t{contacts.City} {contacts.State} \n \t{contacts.ZipCode} ");
            Console.WriteLine($"Email: {contacts.Email} ");

        }
    }
    
}