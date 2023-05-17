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
        /// <summary>
        /// Information of People Parameters
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="MiddleName"></param>
        /// <param name="LastName"></param>
        /// <param name="Birthday"></param>
        /// <param name="Address"></param>
        /// <param name="Photo"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="Weight"></param>
        /// <param name="Height"></param>
        /// </summary>
        public Decimal Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public byte[] Photo { get; set; }
        public string PhoneNumber { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
    }
}
