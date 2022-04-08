﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookMain
    {
        
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter 1 to Add Contact\nEnter 2 to Edit Contact\nEnter 3 to Delete Person From Contact\nEnter 4 to Exit");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("Enter how many contacts you want to add?");
                    int howMany = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= howMany; i++)
                    {
                        Contacts.AddContacts();
                    }
                    AddressBookMain.Main();
                    break;
                case 2:
                    Contacts.EditContact();
                    AddressBookMain.Main();
                    break;
                case 3:
                    Contacts.DeleteContact();
                    AddressBookMain.Main();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Try Again. Wrong key");
                    AddressBookMain.Main();
                    break;
            }
        }
  
    }
   
}


