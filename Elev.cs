

namespace UMLSkola
{
    public class Elev : Anvandare
    {
        //Elev ärver från Anvandare
        //Skapar attribut Kurser:
        public string[] Kurser;
        
        //lägger till privat attribut Betyg:
        private string[] Betyg;

        //Lägger till metod SkickaInUppgift:
        public void SkickaInUppgift(string kurs, string uppgift)
        {
            //Skriver ut att en elev har skickat in en uppgift i en kurs:
            Console.WriteLine($"Eleven {Namn} har skickat in uppgiften: {uppgift} i kursen: {kurs}.");
        }
        //Implementerar den abstrakta metoden VisaSchema:
        public override void VisaSchema()
        {
            Console.WriteLine($"Eleven {Namn} är inskriven i utbildningen .NET Systemutvecklare");
        }

    }
}
