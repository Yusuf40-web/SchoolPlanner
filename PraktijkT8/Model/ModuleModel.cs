using System;
using System.Collections.Generic;
using System.Text;

namespace PraktijkT8.Model
{
    public class ModuleModel
    {
        public int ModuleID { get; set; }

        public string Naam { get; set; }

        public int ThemaID { get; set; }

        public int DocentID { get; set; }

        public string ThemaNaam { get; set; }

        public string DocentVoornaam { get; set; }

        public string DocentAchternaam { get; set; }

        public string Tussenvoegsel { get; set; }

        public string Afbeelding { get; set; }
    }
}
