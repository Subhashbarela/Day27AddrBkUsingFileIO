using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27AddBookUsingFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook myAddressBook = new AddressBook();
            Contacts newContact = new Contacts("Shiva", "Barela", "GERMANY", "7869054332", "shiva37@gmail.com");
            Contacts newContact2 = new Contacts("vinnu", "Pawra", "INDIA", "988765465", "Vinnu243@gmail.com");
           

            myAddressBook.AddContact(newContact);
            myAddressBook.AddContact(newContact2);

            myAddressBook.PrintContacts();


            string path = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\Day27AddBookUsingFileIO\\Day27AddBookUsingFileIO\\Sample.txt";


            myAddressBook.WriteToFile(path);
            //myAddressBook.ReadFromFile(path);
        }
    }
}
