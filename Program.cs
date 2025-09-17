using System;

namespace UMLSkola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här börjar programmet
            //7.Skolans Hanteringssystem
            //Scenario: En skola har elever, lärare, kurser och betyg. Varje elev är inskriven i flera kurser, och varje kurs undervisas av en lärare.Elever får betyg för sin prestation i kurser.
            //Lärare kan tilldela läxor och prov, och elever skickar in sitt arbete för bedömning.

            //Nu skapar jag klasserna, enligt UML-diagrammet. Fast jag använder inte Å Ä Ö i klassnamnen.
            //Första klassen är Skola.cs
            //Lägger till namn för skolan:
            Skola minSkola = new Skola();   
            minSkola.Namn = "NBI/Handelsakademin";
            //Skriver ut skolans namn:
            Console.WriteLine($"Välkommen till skolan: {minSkola.Namn}");

            //Andra klassen är den abstrakta klassen Anvandare.cs

            //Tredje klassen är Larare.cs
           
            //Lägger till en lärare och vilken kurs hen undervisar i:
            Larare larare1 = new Larare();
            larare1.Namn = "Nemo";
            Kurs kurs1 = new Kurs();
            kurs1.Namn = "Introduktion till OOP";
            //Visar lärarens schema:
            larare1.UndervisarIKurs = kurs1;
            larare1.VisaSchema();


            //Fjärde klassen är Elev.cs
            //Lägger till en elev, vilka kurser, vilken uppgift hen skickar in:
            Elev elev1 = new Elev();
            elev1.Namn = "Klas";
            elev1.Kurser = new string[] { "Introduktion till OOP", ".NET Systemutvecklare" };
            elev1.SkickaInUppgift("Introduktion till OOP", "UML-Klass-Diagram");
            //Här ovan gjorde jag något fel, hade kunnat lägga till en kurs i kurs-klassen och sedan lägga till den i elevens kurser.Blir bättre näst gång.
            //Visar elevens schema:
            elev1.VisaSchema();
          

            //Femte klassen är Kurs.cs

            //Sjätte klassen är Betyg.cs

            //Läraren sätter betyg för eleven i kursen:
            larare1.SattBetyg(elev1, "Introduktion till OOP", "VG");


        }
    }
}
