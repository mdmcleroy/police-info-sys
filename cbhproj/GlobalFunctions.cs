using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cbhproj.Models;

namespace cbhproj
{
    public class GlobalFunctions
    {
        private string GetState(mdmcleroyEntities db, int aStateCode)
        {
            var StateData = (from s in db.States
                             where s.StateCode == aStateCode && s.Active == true
                             select s).ToList();

            if (!StateData.Any())
            {
                return "** ** *************************";
            }

            return String.Format("{0} {1}", StateData[0].StateAbbr, StateData[0].StateName);
        }
    }
}
