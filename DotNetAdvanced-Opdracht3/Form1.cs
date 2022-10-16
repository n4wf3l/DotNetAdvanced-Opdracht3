using DotNetAdvanced_Opdracht3;
using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace DotNetAdvanced_Opdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsEveritingDigit(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }


        // Difference betweeen Shallow & Deep Copy : A shallow copy constructs a new compound object and then (to the extent possible) inserts references into it to the objects found in the original. A deep copy constructs a new compound object and then, recursively, inserts copies into it of the objects found in the original. (Bron : docs.python.org)
        // drie stapels :

        Stapel<int> integers = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();
        Stapel<Voetballer> voetballer = new Stapel<Voetballer>();


        private void integersToevoegen_Click_1(object sender, EventArgs e)
        {
            if (IsEveritingDigit(integersInput.Text))
            {
                integers.OpDeStapel(int.Parse(integersInput.Text));

            }
            else
            {
                MessageBox.Show("enkel integers toegelaten ! ");
                integersInput.Text = null;
            }

            integersInput.Text = null;
        }

        private void integersVerwijderen_Click(object sender, EventArgs e)
        {
            if (integers.ToString() != string.Empty)
            {
                integers.vanDeStapel();
            }
            else
            {
                MessageBox.Show(" de stapel is al leeg ! ");
            }

        }

        private void integersLeegmaken_Click(object sender, EventArgs e)
        {
            integers.StapelLeegMaken();
        }

        private void showIntegers_Click(object sender, EventArgs e)
        {
            label6.Text = "integers: " + integers.ToString();
        }


        private void integersCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" old list : " + integers.ToString() + "\n new list  de nieuwe lijst is : " + " " +
               String.Join(",", integers.lijstCopy()));

        }

        private void toevoegenStrings_Click_1(object sender, EventArgs e)
        {
            strings.OpDeStapel(stringsInput.Text);

            stringsInput.Text = null;
        }

        private void integersZoeken_Click(object sender, EventArgs e)
        {
            if (integers.IsAanwezigOpStapel(int.Parse(integersInput.Text)))
            {

                MessageBox.Show(integersInput.Text + " " + "is aanwezig op de stapel van integers");
            }
            else
            {
                MessageBox.Show("sorry maar " + integersInput.Text + " bestaat niet op de stapel");
            }

            integersInput.Text = null;


        }

        private void verwijderenStrings_Click_1(object sender, EventArgs e)
        {
            if (strings.ToString() != string.Empty)
            {
                strings.vanDeStapel();
            }
            else
            {
                MessageBox.Show("de stapel is al leeg !");
            }

        }

        private void leegmakenStrings_Click_1(object sender, EventArgs e)
        {
            strings.StapelLeegMaken();
        }
        private void showStrings_Click(object sender, EventArgs e)
        {
            label8.Text = "strings : " + strings.ToString();

        }

        private void zoekenStrings_Click(object sender, EventArgs e)
        {
            if (strings.IsAanwezigOpStapel(stringsInput.Text))
            {
                MessageBox.Show(stringsInput.Text + " " + "is aanwezig op de stapel van strings");
            }
            else
            {
                MessageBox.Show("sorry maar " + stringsInput.Text + " bestaat niet op de stapel");
            }

            stringsInput.Text = null;
        }

        private void copyStrings_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(strings.ToString() + "\n de nieuwe lijst is : " + " " +
                String.Join(",", strings.lijstCopy()));
        }

        private void toevoegenVoetballer_Click(object sender, EventArgs e)
        {

            if (tb_voetballer.Text == string.Empty || inputLeeftijd.Text == string.Empty)
            {

                MessageBox.Show("beide velden moeten ingevuld worden ! ");

            }
            else if (IsEveritingDigit(inputLeeftijd.Text) == false)
            {
                MessageBox.Show(" leeftijd moet enkel getallen bevatten");
            }

            else
            {
                voetballer.OpDeStapel(new Voetballer(tb_voetballer.Text, int.Parse(inputLeeftijd.Text)));
            }

            tb_voetballer.Text = null;
            inputLeeftijd.Text = null;
        }

        private void verwijderenVoetballer_Click(object sender, EventArgs e)
        {
            if (voetballer.ToString() != string.Empty)
            {
                voetballer.vanDeStapel();
            }
            else
            {
                MessageBox.Show("sorry maar de stapel is al leeg !");
            }

        }

        private void leegmakenVoetballer_Click(object sender, EventArgs e)
        {
            voetballer.StapelLeegMaken();
        }

        private void showListVoetballer_Click(object sender, EventArgs e)
        {
            label7.Text = "personen : " + voetballer.ToString();
        }

        private void zoekenVoetballer_Click(object sender, EventArgs e)
        {
            if (voetballer.IsAanwezigOpStapel(new Voetballer(tb_voetballer.Text, int.Parse(inputLeeftijd.Text))))
            {
                MessageBox.Show(" de persoon met naam : " + " " + tb_voetballer.Text + " en met leeftijd : " + " " + inputLeeftijd.Text + " " + "is aanwezig in de lijst van personen");
            }
            else
            {
                MessageBox.Show("de persoon met naam : " + " " + tb_voetballer.Text + " " + "bestaat niet in de lijst");
            }
        }

        private void copyVoetballer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" old list : " + voetballer.ToString() + "\n new list  de nieuwe lijst is : " + " " +
                String.Join(":", voetballer.lijstCopy()));
        }

        private void inputleeftijd_TextChanged(object sender, EventArgs e)
        {

        }

        private void integersInput_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
