using System;
using System.Collections.Generic;

namespace DotNetAdvanced_Opdracht3
{
    internal class Stapel<Stapeltje>
    {

        private List<Stapeltje> listOfStapel = new List<Stapeltje>();
        private List<Stapeltje> stapellijstCopy = new List<Stapeltje>();


        public void OpDeStapel(Stapeltje toeTeVoegen)
        {
            listOfStapel.Add(toeTeVoegen);
        }

        public Stapeltje vanDeStapel()
        {
            if (listOfStapel.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            Stapeltje updatedLijst = listOfStapel[listOfStapel.Count - 1];
            listOfStapel.RemoveAt(listOfStapel.Count - 1);

            return updatedLijst;
        }

        public void StapelLeegMaken()
        {
            listOfStapel.Clear();
        }


        public bool IsAanwezigOpStapel(Stapeltje search)
        {
            foreach (Stapeltje elements in listOfStapel)
            {

                if (elements.ToString() == search.ToString())
                {

                    return true;

                }

            }

            return false;

        }

        public override string ToString()
        {
            string lijst = "";

            foreach (Stapeltje s in listOfStapel)
            {
                lijst += s.ToString() + " " + ",";
            }

            return lijst;
        }

        public List<Stapeltje> lijstCopy()
        {
            stapellijstCopy = listOfStapel.GetRange(0, listOfStapel.Count);

            return stapellijstCopy;
        }

    }
}
