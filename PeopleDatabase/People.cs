using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabase
{
    internal class People
    {
        public Decimal Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public byte[] Photo { get; set; }
        public string PhoneNumber { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
    }
}
