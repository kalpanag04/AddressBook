using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

    interface IOperationalMethods
    {
        public void ContactViewMethod();
        public void Listview();
        public void NewContact();
        public void DeleteContact();
        public void EditContact();

    }
    class ContactView : IOperationalMethods
    {
        public static List<Contacts> contactsList = new List<Contacts>();

        public void ContactViewMethod()
        {
            Contacts Person1 = new Contacts
            {
                FirstName = "Kalpana",
                LastName = "G",
                Address = "Ags",
                City = "Siruguppa",
                State = "Karnataka",
                ZipCode = 583114,
                PhoneNumber = 1234567890,
                Email = "kalpanag808@gmail.com"
            };
            Contacts Person2 = new Contacts
            {
                FirstName = "Abc",
                LastName = "D",
                Address = "ABC",
                City = "Bellary",
                State = "KA",
                ZipCode = 400000,
                PhoneNumber = 1234567891,
                Email = "abc@gmail.com"
            };
            Person1.ValidateContactDetails();
            Person2.ValidateContactDetails();

            //storing contact details to List
            contactsList.Add(Person1);
            contactsList.Add(Person2);

        }

        public void Listview()
        {
            try
            {
                if (contactsList.Count == 0)
                    Console.WriteLine("No Contacts to Display");
                else
                {
                    foreach (Contacts i in contactsList)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Contacts");
                        Console.WriteLine($"Full Name: {i.FirstName} {i.LastName}");
                        Console.WriteLine($"Phone Number: {i.PhoneNumber}");
                        Console.WriteLine($"Email: {i.Email}");
                        Console.WriteLine($"Address: {i.Address}, \n \t{i.City}, {i.State}, {i.ZipCode}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
      public void NewContact()
        {
            try
            {
                Contacts Person3 = new Contacts();
                Console.WriteLine("Add a new contact.");
                Console.WriteLine("Enter First Name: ");
                Person3.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                Person3.LastName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                Person3.Address = Console.ReadLine();
                Console.WriteLine("Enter City: ");
                Person3.City = Console.ReadLine();
                Console.WriteLine("Enter State: ");
                Person3.State = Console.ReadLine();
                Console.WriteLine("Enter ZipCode: ");
                Person3.ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number: ");
                Person3.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Email: ");
                Person3.Email = Console.ReadLine();
                //validating contact details
                Person3.ValidateContactDetails();
                //adding contact to list
                contactsList.Add(Person3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("New contact entry aborted.");
            }
        }

       public void DeleteContact()
        {
            try
            {
                if (contactsList.Count == 0)
                {
                    Console.WriteLine("No Contacts available to Delete");
                }
                else
                {
                    int i = 0;
                    Console.WriteLine("Select the contact you want to Delete : ");
                    foreach (Contacts contacts in ContactView.contactsList)
                    {

                        Console.WriteLine($" press {i} for {contacts.FirstName}");
                        i++;
                    }
                    int sel = Convert.ToInt32(Console.ReadLine());
                    while (sel >= i || sel < 0)
                    {
                        Console.WriteLine("invalid choice made,");
                        Console.WriteLine("enter a valid choice");
                        sel = Convert.ToInt32(Console.ReadLine());
                    }
                    contactsList.RemoveAt(sel);
                    Console.WriteLine("Contact deleted successfully!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
      public void EditContact()
        {
            try
            {
                if (contactsList.Count == 0)
                {
                    Console.WriteLine("No Contacts available to Edit");
                }
                else
                {
                    int i = 0;
                    Console.WriteLine("Select the contact you want to Edit : ");
                    foreach (Contacts contacts in ContactView.contactsList)
                    {

                        Console.WriteLine($" press {i} for {contacts.FirstName}");
                        i++;
                    }
                    int sel = Convert.ToInt32(Console.ReadLine());
                    while (sel >= i || sel < 0)
                    {
                        Console.WriteLine("invalid choice made,");
                        Console.WriteLine("enter a valid choice");
                        sel = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("-------Before editing-------");
                    CustomView(sel);
                    Console.WriteLine("Enter new Details");
                    Contacts Person3 = new Contacts();
                    Console.WriteLine("Add a new contact.");
                    Console.WriteLine("Enter First Name: ");
                    Person3.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    Person3.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    Person3.Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    Person3.City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    Person3.State = Console.ReadLine();
                    Console.WriteLine("Enter ZipCode: ");
                    Person3.ZipCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number: ");
                    Person3.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Email: ");
                    Person3.Email = Console.ReadLine();
                    //validating contact details
                    Person3.ValidateContactDetails();
                    //removing contact
                    contactsList.RemoveAt(sel);
                    //adding new details of contact at list
                    contactsList.Insert(sel, Person3);
                    Console.WriteLine();
                    Console.WriteLine("Contact edit successful!!");

                    Console.WriteLine("-------After editing-------");
                    CustomView(sel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void CustomView(int sel)
        {
            Console.WriteLine();
            Console.WriteLine("Contacts");
            Console.WriteLine($"Full Name: {contactsList[sel].FirstName} {contactsList[sel].LastName}");
            Console.WriteLine($"Phone Number: {contactsList[sel].PhoneNumber}");
            Console.WriteLine($"Email: {contactsList[sel].Email}");
            Console.WriteLine($"Address: {contactsList[sel].Address}, \n \t{contactsList[sel].City}, {contactsList[sel].State}, {contactsList[sel].ZipCode}");
            Console.WriteLine();
        }
    }
    
}
