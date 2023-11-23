using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.IsKurApi.Models.HelperClass
{
    public class Status
    {
        public String GetStatus(EStatus eStatus)
        {
            switch (eStatus)
            {
                case EStatus.Ozel:
                    return "Özel";
                case EStatus.Kamu:
                    return "Kamu";
                case EStatus.YabanciIsVeren:
                    return "Yabanci İş Veren";
                case EStatus.BireyselIsVeren:
                    return "Bireysel İş Veren";
                default:
                    return default;
            }
        }
    }

    public enum EStatus
    {
        Ozel,
        Kamu,
        YabanciIsVeren,
        BireyselIsVeren
    }
}