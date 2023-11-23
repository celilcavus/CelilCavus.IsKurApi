using CelilCavus.IsKurApi.Context;
using CelilCavus.IsKurApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace CelilCavus.IsKurApi.Controllers
{

    public class WorkController : ApiController
    {
        private IsKurContext isKurContext = new IsKurContext();
  
        public IEnumerable<Work> Get()
        {
            return isKurContext.Work.ToList();
        }

        public Work Get(int id)
        {
            var i = isKurContext.Work.FirstOrDefault(x => x.Id == id);
            return i;
        }
        public void Post(Work work)
        {
            isKurContext.Work.Add(work);
            isKurContext.SaveChanges();
        }
        public void Put(Work work)
        {
            var i = isKurContext.Work.FirstOrDefault(x => x.Id == work.Id);
            i.Name = work.Name;
            i.Position = work.Position;
            i.DeadLine = work.DeadLine;
            i.UpdateAtDate = work.UpdateAtDate;
            i.JobDescription = work.JobDescription;
            i.JobSkill = work.JobSkill;
            i.Profession = work.Profession;
            i.ProfessionExpreince = work.ProfessionExpreince;
            i.Gender = work.Gender;
            i.Year = work.Year;
            i.disability = work.disability;
            //Work entity'sine isActive property'si eklenicek!
            i.shift = work.shift;

            i.Adress.Country = work.Adress.Country;
            i.Adress.District = work.Adress.District;
            i.Adress.City = work.Adress.City;
            i.Adress.GeneralAdress = work.Adress.GeneralAdress;

            i.Contact.Name = work.Contact.Name;
            i.Contact.Statu = work.Contact.Statu;
            i.Contact.Email = work.Contact.Email;
            i.Contact.PhoneNumber = work.Contact.PhoneNumber;
            
            //Test
            i.OrderDescription = work.OrderDescription;
            
            isKurContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var i = isKurContext.Work.FirstOrDefault(x => x.Id == id);
            isKurContext.Work.Remove(i);
            isKurContext.SaveChanges();
        }
    }
}
