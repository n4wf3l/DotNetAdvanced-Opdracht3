using System;
using System.Collections.Generic;

namespace DotNetAdvanced_Opdracht3
{
    internal class Stapel<Stapeltje>
    {

        private List<Stapeltje> Stapellijst = new List<Stapeltje>();
        private List<Stapeltje> stapellijstCopy = new List<Stapeltje>();


        public void OpDeStapel(Stapeltje toeTeVoegen)
        {
            Stapellijst.Add(toeTeVoegen);
        }

        public Stapeltje vanDeStapel()
        {
            if (Stapellijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            Stapeltje updatedLijst = Stapellijst[Stapellijst.Count - 1];
            Stapellijst.RemoveAt(Stapellijst.Count - 1);

            return updatedLijst;
        }

        public void StapelLeegMaken()
        {
            Stapellijst.Clear();
        }


        public bool IsAanwezigOpStapel(Stapeltje tezoeken)
        {
            foreach (Stapeltje elements in Stapellijst)
            {

                if (elements.ToString() == tezoeken.ToString())
                {

                    return true;

                }

            }

            return false;

        }

        public override string ToString()
        {
            string lijst = "";

            foreach (Stapeltje t in Stapellijst)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public List<Stapeltje> lijstCopy()
        {
            stapellijstCopy = Stapellijst.GetRange(0, Stapellijst.Count);

            return stapellijstCopy;
        }

    }
}
