using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.IsKurApi.Models
{
    public class OrderDescription
    {
        public decimal Salary { get; set; }
        public bool MilitaryService { get; set; }


        public String GetMilitaryDescription(bool IsMilitary)
        {
            switch (IsMilitary)
            {
                case true:
                    return "Askerliğini Fiilen Yapmış";
                case false:
                    return "Muaf,Tecilli veya Askerliğini Fiilen Yapmamış";
                default:
                    return default;
            }
        }
        public OrderDescription()
        {
            Salary = decimal.Zero;
            MilitaryService = false;
        }

    }
}