using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_module3
{
    public class Contact
    {
        public Contact(string neme, string phone)
        {
            Name = neme;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
