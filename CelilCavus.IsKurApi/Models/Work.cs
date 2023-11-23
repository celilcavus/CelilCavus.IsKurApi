using CelilCavus.IsKurApi.Models.Enums;
using CelilCavus.IsKurApi.Models.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.IsKurApi.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ModeOfOperation Operation { get; set; }
        public int Position { get; set; }
        public Status Statu { get; set; }

        public DateTime DeadLine { get; set; }

        public DateTime CreateAtDate { get; set; }
        public DateTime UpdateAtDate { get; set; }
        //job
        public string JobDescription { get; set; } = String.Empty;

        public string JobSkill { get; set; } = String.Empty;
        //

        //Profession
        public string Profession { get; set; }
        public byte ProfessionExpreince { get; set; }
        public Gender Gender { get; set; }

        public byte Year { get; set; }

        //

        public bool disability { get; set; }
        public bool shift { get; set; }

        public Adress Adress { get; set; }
        public Contact Contact { get; set; }

        public OrderDescription OrderDescription { get; set; }
        public Work()
        {
            DeadLine = DateTime.Now;
            CreateAtDate = DateTime.Now;
            UpdateAtDate = DateTime.Now;
            //
            ProfessionExpreince = 0;
            //
            disability = false;
            shift = false;

            //
            Year = 0;
            Gender = Gender.Erkek;
        }
    }
}