using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliotheque
{
    public partial class Main : Form
    {
        // Liste de livres
        private List<Livre> ListeLivres = new List<Livre>();
        
        // Nom du fichier de sérialisation
        private String nomFic = "sauvLivres";

        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Positionner le combobox par défaut au statut "Conserver"
            comboBox1.SelectedIndex = 0;

            // récupérer la sauvegarde des contacts, si elle existe
            Object recupLivres = Serialise.Recup(nomFic);
            if (recupLivres != null)
            {
                ListeLivres = (List<Livre>)recupLivres;

                // remplir de la listbox avec les contacts récupérés
                MajListeLivres();
            }
        }

        private void MajListeLivres()
        {
            BindingList<Livre> bdlLivres = new BindingList<Livre>(ListeLivres);
            listBox1.DataSource = bdlLivres;
            Serialise.Sauve(nomFic, ListeLivres);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce livre ?", "Confirmation", MessageBoxButtons.YesNo) == (DialogResult.Yes))
                {
                    ListeLivres.RemoveAt(listBox1.SelectedIndex);
                    MajListeLivres();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Livre unLivre = ListeLivres[listBox1.SelectedIndex];
            unLivre.SetStatut("[Donner]");
            MajListeLivres();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string unTitre = textBoxTitre.Text;
            string unAuteur = textBoxAuteur.Text.ToUpper();
            string unStatut = '[' + comboBox1.SelectedItem.ToString() + ']';
            ListeLivres.Add(new Livre(unTitre, unAuteur, unStatut));
            textBoxTitre.Clear();
            textBoxAuteur.Clear();
            MajListeLivres();
        }

        private void textBoxAuteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Livre unLivre = ListeLivres[listBox1.SelectedIndex];
            unLivre.SetStatut("[Conserver]");
            MajListeLivres();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Livre unLivre = ListeLivres[listBox1.SelectedIndex];
            unLivre.SetStatut("[Vendre]");
            MajListeLivres();
        }
    }
}
