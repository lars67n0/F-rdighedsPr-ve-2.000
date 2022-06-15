using System;
using System.Collections.Generic;
using System.Text;

namespace FærdighedsPrøve__Hjemme
{
    public class BadeTidsperiode
    {

        public int Id {get; set; }
        public string Type { get; set; }
        public DayOfWeek Ugedag { get; set; }
        public DateTime StartTidspunkt { get; set; }
        public DateTime SlutTidspunkt { get; set; }

        public BadeTidsperiode (int id,string type, DayOfWeek ugedag, DateTime start, DateTime slut)
        {
            this.Id = id;
            this.Type = type;
            this.Ugedag = ugedag;
            this.StartTidspunkt = start;
            this.SlutTidspunkt = slut;
        }

        public override string ToString()
        {
            return $"ID : {Id}, Type Aktivitet : {Type}. Hvornår : {Ugedag}, Start : {StartTidspunkt} Slut : {SlutTidspunkt}";
        }

        public static Dictionary<string, Kreds> KredsDictionary
        {
            get { return KredsDictionary; }
        }

        private static Dictionary<string, Kreds> kredsDictionary = new Dictionary<string, Kreds>()
        {
            
         
    };

        public static void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Alle Kredse");
            foreach (var kreds in kredsDictionary)
            {
                Console.WriteLine();
                Console.WriteLine(kreds);
                Console.WriteLine("______________________________");
            }
        }

        //ADD 
        public static void Create(Kreds kreds)
        {
            kredsDictionary.Add(kreds.ID, kreds);
        }

        //Delete
        public static void Delete(Kreds kreds)
        {
            kredsDictionary.Remove(kreds.ID);
        }


    }
}
