namespace DotNetAdvanced_Opdracht3
{
    internal class Voetballer
    {
        private string NaamVoetballer { get; set; }
        private int Leeftijd { get; set; }

        public Voetballer(string naam, int leeftijd)
        {
            NaamVoetballer= naam;
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return "De voetballer is " + NaamVoetballer + " en is " + Leeftijd + " jaar oud.";
        }
    }
}
