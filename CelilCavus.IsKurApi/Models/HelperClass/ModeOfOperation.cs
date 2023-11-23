using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CelilCavus.IsKurApi.Models.Enums
{
    public class ModeOfOperation
    {

        public String GetOperation(EModeOfOperation eModeOfOperation)
        {
            switch (eModeOfOperation)
            {
                case EModeOfOperation.Tam_Zamanli:
                    return "Tam Zamanali";
                case EModeOfOperation.Yari_Zamanli:
                    return "Yarı Zamanli";
                default:
                    return default;
            }
        }
    }
    public enum EModeOfOperation
    {
        Tam_Zamanli,
        Yari_Zamanli,
    }
}