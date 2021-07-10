using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICMS_Reader
{
    public class Benotung
    {
        public string Fach;
        public string Note;
        public string Versuche;
        public string Credits;
        public string Semester;
        public DateTime SaveDate;

        public Benotung()
        {
            Fach = "";
            Note = "";
            Credits = "";
            Semester = "";
            Versuche = "";
            SaveDate = DateTime.Now;
        }

        public override string ToString()
        {
            return Fach + ";" + Note + ";" + Versuche + ";" + Credits + ";" + Semester + ";" + SaveDate.ToString("dd.MM.yyyy");
        }
    }

    enum BenotungPropertyOrder
    {
        Fach = 0,
        Note = 1,
        Versuche = 2,
        Credits = 3,
        Semester = 4,
        SaveDate = 5
    }
}
