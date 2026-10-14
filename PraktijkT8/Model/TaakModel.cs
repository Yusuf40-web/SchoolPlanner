using System;
using System.Collections.Generic;
using System.Text;

namespace PraktijkT8.Model
{
    public class TaakModel
    {
        public int TaakID { get; set; }

        public string Naam { get; set; }

        public string Omschrijving { get; set; }

        public DateTime StartDatum { get; set; }

        public DateTime Inleverdatum { get; set; }

        public string Status { get; set; }

        public int ModuleID { get; set; }
    }
}
