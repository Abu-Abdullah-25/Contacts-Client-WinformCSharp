using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApiClient.DTOs
{
    public class Contact
    {
        public int ContactID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int CountryID { set; get; }
        public string? ImagePath { get; set; } // Nullable string

    }
}
