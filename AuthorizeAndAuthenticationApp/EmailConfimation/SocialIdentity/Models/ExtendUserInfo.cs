using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialIdentity.Models
{
    public class ExtendUserInfo
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual ICollection <ApplicationUser> Users { get; set; }
    }
}