using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CG.Contacts.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MobileNumber { get; set; }
        public int HomeNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}