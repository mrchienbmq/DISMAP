using System;

namespace T1807M1.DISMAP
{
    public class Contact
    {
        public string name;
        public int phone;

        public Contact()
        {
        }

        public Contact(string name, int phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Phone
        {
            get => phone;
            set => phone = value;
        }

        

        
    }
}