using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliotheque
{
    public partial class Main : Form
    {
        // Création de la collection de livres
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
            comboBoxStatut.SelectedIndex = 0;

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
            // trier la collection en comparant les noms des auteurs
            ListeLivres.Sort((auteur1, auteur2) => auteur1.GetAuteur().CompareTo(auteur2.GetAuteur()));

            // lier la ListBox avec lesContacts pour la remplir
            BindingList<Livre> bdlLivres = new BindingList<Livre>(ListeLivres);
            listBox1.DataSource = bdlLivres;

            // sauver la liste dans le fichier
            Serialise.Sauve(nomFic, ListeLivres);

            // compteur du nombre de livres dans la bibliothèque
            LblNumberofBooks.Text = ListeLivres.Count.ToString();
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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            // Ajoute un nouveau livre à la collection
            string unTitre = textBoxTitre.Text;
            string unAuteur = textBoxAuteur.Text.ToUpper();
            string unStatut = comboBoxStatut.SelectedItem.ToString();
            ListeLivres.Add(new Livre(unTitre, unAuteur, unStatut));

            // Vide le contenu des textbox après l'ajout
            textBoxTitre.Clear();
            textBoxAuteur.Clear();

            // Mise à jour de la listbox

            MajListeLivres();
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            // Supprime le livre sélectionné de la collection
            if (listBox1.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce livre ?", "Confirmation", MessageBoxButtons.YesNo) == (DialogResult.Yes))
                {
                    ListeLivres.RemoveAt(listBox1.SelectedIndex);
                    MajListeLivres();
                }
            }
        }

        private void BtnKeepBook_Click(object sender, EventArgs e)
        {
            // Change le statut du lire à "Conserver"
            Livre unLivre = ListeLivres[listBox1.SelectedIndex];
            unLivre.SetStatut("Conserver");
            MajListeLivres();
        }

        private void BtnGiveBook_Click(object sender, EventArgs e)
        {
            // Change le statut du lire à "Donner"
            Livre unLivre = ListeLivres[listBox1.SelectedIndex];
            unLivre.SetStatut("Donner");
            MajListeLivres();
        }

        private void BtnBookSell_Click(object sender, EventArgs e)
        {
            // Change le statut du lire à "Vendre"
            Livre unLivre = ListeLivres[listBox1.SelectedIndex];
            unLivre.SetStatut("Vendre");
            MajListeLivres();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
