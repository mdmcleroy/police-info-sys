using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using cbhproj.Models;

namespace cbhproj
{
    public class GlobalFunctions
    {
        public static string GetState(mdmcleroyEntities db, int aStateCode)
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

        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public static bool Contains(string str, char ch)
        {
            foreach (char c in str)
            {
                if (c == ch)
                    return true;
            }

            return false;
        }
    }
}
