namespace UMLSkola
{
    public class Skola
    {
        //Skapar attribut Namn:
        
        public string Namn;

        //Skapar metod för att anställa lärare:
        public void AnstallLarare(Larare larare)
        {
            //Skriver ut att en lärare har anställts:
            Console.WriteLine($"Läraren {larare.Namn} har anställts på skolan {Namn}.");

        }

    }
}
