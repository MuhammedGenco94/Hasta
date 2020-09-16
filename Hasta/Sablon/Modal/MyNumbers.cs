using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sablon.Modal;

namespace Sablon.Modal
{
    class MyNumbers
    {
        HastaDBDataContext _db = new HastaDBDataContext();

        public string GetNewPatientID()
        {
            try
            {
                int numara = (from s in _db.tblHastaBilgileris orderby s.ID descending select s).First().ID;
                numara++;
                string num = numara.ToString().PadLeft(9, '0');
                
                return num;
            }
            catch (Exception)
            {
                return "000000001";
            }
        }

    }
}
