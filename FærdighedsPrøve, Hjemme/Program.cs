using System;

namespace FærdighedsPrøve__Hjemme
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPG 1

            Kreds k1 = new Kreds("1", "Navn1", "Adresse1", 5);
            Kreds k2 = new Kreds("2", "Navn2", "Adresse2", 6);
            Kreds k3 = new Kreds("3", "Navn3", "Adresse3", 7);
            Kreds k4 = new Kreds("4", "Navn4", "Adresse4", 8);


            Console.WriteLine("Grupper : ");
            Console.WriteLine();
            Console.WriteLine(k1.ToString());
            Console.WriteLine();
            Console.WriteLine(k2.ToString());
            

            //OPG 2

            DateTime time1 = new DateTime().AddHours(6).AddMinutes(10);
            DateTime time2 = new DateTime().AddHours(8).AddMinutes(10);

            DateTime time3 = new DateTime().AddHours(10).AddMinutes(10);
            DateTime time4 = new DateTime().AddHours(12).AddMinutes(10);

            DateTime time5 = new DateTime().AddHours(18).AddMinutes(10);
            DateTime time6 = new DateTime().AddHours(21).AddMinutes(10);
            BadeTidsperiode b1 = new BadeTidsperiode(1, "Morgen", DayOfWeek.Friday,(time1),(time2));
            BadeTidsperiode b2 = new BadeTidsperiode(1, "Middag", DayOfWeek.Friday, (time3), (time4));
            BadeTidsperiode b3 = new BadeTidsperiode(1, "Aften", DayOfWeek.Friday, (time5), (time6));
           
            Console.WriteLine();
            Console.WriteLine("Alle Aktiviteter : ");
            Console.WriteLine();
            Console.WriteLine(b1.ToString());
            Console.WriteLine();
            Console.WriteLine(b2.ToString());
            Console.WriteLine();
            Console.WriteLine(b3.ToString());

            //OPG 4
            Console.WriteLine();
            BadeTidsperiode.Create(k1);
            BadeTidsperiode.Create(k2);
            BadeTidsperiode.Create(k3);
            BadeTidsperiode.Create(k4);

            BadeTidsperiode.Print();

            BadeTidsperiode.Delete(k4);
            BadeTidsperiode.Print();


        }
    }
}
