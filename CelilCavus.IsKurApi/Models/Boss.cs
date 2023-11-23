using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.IsKurApi.Models
{
    public class Boss
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string TCNo { get; set; }
        public DateTime CreateAtDate { get; set; }
        public DateTime UpdateAtDate { get; set; }

        public String FullName()
        {
            return Name + LastName;
        }

        public Boss()
        {
            CreateAtDate = DateTime.Now;
            UpdateAtDate = DateTime.Now;
        }
    }
}