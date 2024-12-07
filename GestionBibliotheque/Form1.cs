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
        // création de la collection de livres
        private List<Livre> ListeLivres = new List<Livre>();
        
        // nom du fichier de sérialisation
        private String nomFic = "sauvLivres";

        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // positionner le combobox par défaut sur "Conserver"
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

            // compteur du nombre de livres à vendre dans la bibliothèque
            LblNbBooksToSell.Text = ListeLivres.Count(livre => livre.GetStatut() == "Vendre").ToString();

            // compteur du nombre de livres à donner dans la bibliothèque
            LblNbBooksToGive.Text = ListeLivres.Count(livre => livre.GetStatut() == "Donner").ToString();

            // compteur du nombre de livres à recycler dans la bibliothèque
            LblNbBooksToRecycle.Text = ListeLivres.Count(livre => livre.GetStatut() == "Recycler").ToString();
        }


        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            // ajoute un nouveau livre à la collection
            string unTitre = textBoxTitre.Text;
            string unAuteur = textBoxAuteur.Text.ToUpper();
            string unStatut = comboBoxStatut.SelectedItem.ToString();
            Livre nouvLivre = new Livre(unTitre, unAuteur, unStatut);
            ListeLivres.Add(nouvLivre);

            

            // vide le contenu des textbox après l'ajout
            textBoxTitre.Clear();
            textBoxAuteur.Clear();

            // mise à jour de la listbox
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

        private void BtnRecycleBook_Click(object sender, EventArgs e)
        {
            // Change le statut du lire à "Recycler"
            Livre unLivre = ListeLivres[listBox1.SelectedIndex];
            unLivre.SetStatut("Recycler");
            MajListeLivres();
        }
    }
}
