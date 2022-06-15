using System;
using System.Collections.Generic;
using System.Text;

namespace FærdighedsPrøve__Hjemme
{
    public class Kreds
    {
        public string ID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int Antaldeltager { get; set; }

        public Kreds(string id, string navn, string adresse, int antal)
        {
            this.ID = id;
            this.Navn = navn;
            this.Adresse = adresse;
            this.Antaldeltager = antal;
        }

        public override string ToString()
        {
            return $"Kredsens ID : {ID}. Gruppens Navn : {Navn}, deres adresse : {Adresse} og Antal Deltagere {Antaldeltager}";
        }
    }
}
