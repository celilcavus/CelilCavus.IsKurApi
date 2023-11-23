using CelilCavus.IsKurApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.IsKurApi.Models
{
    public class Contact
    {

        public string Name { get; set; }
        public EStatus Statu { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
    
}