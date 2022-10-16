namespace DotNetAdvanced_Opdracht3
{
    internal class Voetballer
    {
        private string Naam { get; set; }
        private int Leeftijd { get; set; }

        public Voetballer(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
        public override string ToString()
        {
            return "ik noem " + Naam + " en ik ben " + Leeftijd;
        }



    }
}
