using System;
using System.Collections.Generic;

namespace T1807M1.DISMAP
{
    public class PhoneManager : Contact
    {
        List<Contact> x = new List<Contact>();

        public PhoneManager()
        {
        }


        public PhoneManager(string name, int phone)
        {
          
            this.Name = name;
            this.Phone = phone;
        }

       


        public  void Input()
        {
            Console.WriteLine("Input Name and Phone");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Inut Name ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input Phone");
            Phone = Convert.ToInt32(Console.ReadLine());
            
            Contact ad = new Contact(Name,Phone);
            x.Add(ad);
        }
        
        public  void DisPlay()
        {
            Console.WriteLine("------------------ADDRESS BOOK--------------------");
            Console.WriteLine("Contact Name : " + Name + " Phone Number : " +Phone);
            
        }


        public void SearPhoneByName(string name)
        {
            for (int i = 0; i < x.Count; i++)
            {
                Contact a = x[i];
                string v = a.Name;
                int d = a.Phone;
                if (v.Equals(name))
                {
                    Console.WriteLine(a.Name);
                    Console.WriteLine(a.Phone);
                }
                else
                {
                    Console.WriteLine("Not found");
                }


            }
        }
        
    }
}