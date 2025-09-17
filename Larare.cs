
namespace UMLSkola
{
    public class Larare : Anvandare
    {
        //Lärare ärver från Anvandare
        //Skapar attribut UndervisarIKurser:
        public Kurs UndervisarIKurs;

        //Lägger till metoder SattBetyg och GoraProv
        public void SattBetyg(Elev elev, string kurs, string betyg)
        {
            //Skriver ut att läraren har satt ett betyg för en elev i en kurs:
            Console.WriteLine($"Läraren {Namn} har satt betyget {betyg} för eleven {elev.Namn} i kursen {kurs}.");
        }

        //Implementerar den abstrakta metoden VisaSchema:
        public override void VisaSchema()
        {
            Console.WriteLine($"Läraren {Namn} undervisar i kursen: {UndervisarIKurs.Namn}.");
        }


    }
}
