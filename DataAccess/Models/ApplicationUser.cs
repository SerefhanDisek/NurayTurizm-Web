using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool TermsAccepted { get; set; }
        public bool CommercialEmailsAccepted { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }  
        public ICollection<Yorum> Yorumlar { get; set; }
    }
}
