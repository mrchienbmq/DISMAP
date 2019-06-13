using System;
using System.Collections;

namespace T1807M1.DISMAP
{
    public class main
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(0943641918, "chien");
            ht.Add(091231231, "duy");

            Contact ct = new Contact();
            PhoneManager pn = new PhoneManager();
            

            int x;



            while (true)
            {
                Console.WriteLine("Welconme Address Phone");
                Console.WriteLine("1. ADD NEW CONTACT");
                Console.WriteLine("2. Find a contact by name");
                Console.WriteLine("3. Display Contact");
                Console.WriteLine("4. EXIT");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        pn.Input();
                        break;
                    case 2:
                        Console.WriteLine("Enter Name");
                        string a = Console.ReadLine();
                        pn.SearPhoneByName(a);
                        break;
                    case 3:
                        pn.DisPlay();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                }
            }


        }
    }

}

