using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestionBibliotheque
{
    public partial class Main : Form
    {
        // création de la collection de livres
        private List<Livre> ListeLivres = new List<Livre>();


        // nom du fichier de sérialisation
        private String nomFic = "sauvLivres";

        //dossier de sérialisation
        string dossierSauvegarde = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TriBibli"); 
        

        public Main()
        {
            InitializeComponent();
            Directory.CreateDirectory(dossierSauvegarde);
            nomFic = Path.Combine(dossierSauvegarde, "sauvLivres.dat");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // positionner le combobox par défaut sur "Conserver"
            comboBoxStatut.SelectedIndex = 0;

            // désactiver tous les boutons radio
            BtnRConserver.Checked = false;
            BtnRDonner.Checked = false;
            BtnRVendre.Checked = false;
            BtnRRecycler.Checked = false;

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

            // lier la ListBox avec ListeLivres pour la remplir
            BindingList<Livre> bdlLivres = new BindingList<Livre>(ListeLivres);
            listBox1.DataSource = bdlLivres;

            // sauvegarder la liste dans le fichier
            Serialise.Sauve(nomFic, ListeLivres);

            // compteurs du nombre de livres
            LblNumberofBooks.Text = "Livres : " + ListeLivres.Count.ToString() + 
                "        Conserver : " + ListeLivres.Count(livre => livre.GetStatut() == "Conserver").ToString() +
                "        Vendre : " + ListeLivres.Count(livre => livre.GetStatut() == "Vendre").ToString() +
                "        Donner : " + ListeLivres.Count(livre => livre.GetStatut() == "Donner").ToString() +
                "        Recycler : " + ListeLivres.Count(livre => livre.GetStatut() == "Recycler").ToString();


            // désélectionner la ligne sélectionnée après la mise à jour et désactiver les boutons radio
            listBox1.SelectedIndex = -1;
            BtnRConserver.Checked = false;
            BtnRDonner.Checked = false;
            BtnRVendre.Checked = false;
            BtnRRecycler.Checked = false;
        }

        private int RecupIndexListeLivres()
        {
            // récupère a partir de l'index listbox l'indice d'un seul livre sélectionné dans la collection
            int index = 0 ;

            if (listBox1.SelectedIndex != -1)
            {
                string currItem = listBox1.SelectedItem.ToString();
                foreach (Livre livre in ListeLivres)
                {
                    string str = livre.GetAuteur().ToString() + ". " + livre.GetTitre().ToString() + ' ' + '[' + livre.GetStatut().ToString() + ']';
                    if (currItem == str)
                    {
                        index = ListeLivres.IndexOf(livre);
                    }
                } 
            }
            return index;
        }

        private void ChangeStatutLivreSelectionnes(string statut)
        {
            //Change le statut d'un ou plusieurs livres sélectionnés dans la collection
            if (listBox1.SelectedIndex != -1)
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int indexlist = listBox1.SelectedIndices[i];
                    string currItem = listBox1.Items[indexlist].ToString();
                    foreach (Livre livre in ListeLivres)
                    {
                        string str = livre.GetAuteur().ToString() + ". " + livre.GetTitre().ToString() + ' ' + '[' + livre.GetStatut().ToString() + ']';
                        if (currItem == str)
                        {
                            int index = 0;
                            index = ListeLivres.IndexOf(livre);
                            Livre unLivre = ListeLivres[index];
                            unLivre.SetStatut(statut);
                        }
                    }
                }
                MajListeLivres();
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAuteur.Text) == false & string.IsNullOrEmpty(textBoxTitre.Text) == false) 
            {
                // création d'un nouvel objet livre à ajouter
                string unTitre = textBoxTitre.Text;
                string unAuteur = textBoxAuteur.Text.ToUpper();
                string unStatut = comboBoxStatut.SelectedItem.ToString();
                Livre nouvLivre = new Livre(unTitre, unAuteur, unStatut);
                bool unDoublon = false;

                // vérification que le livre n'existe pas déjà dans la collection
                foreach(Livre livre in ListeLivres)
                {
                    if (livre.GetAuteur().ToLower() == nouvLivre.GetAuteur().ToLower() && livre.GetTitre().ToLower() == nouvLivre.GetTitre().ToLower())
                    {
                        unDoublon = true;
                    }
                }

                // ajout du livre s'il ne s'agit pas d'un doublon
                if (unDoublon == false)
                {
                    ListeLivres.Add(nouvLivre);
                }

                else
                {
                    // demande à l'utilisateur s'il souhaite ajouter un doublon
                    if (MessageBox.Show("Un livre du même auteur et ayant le même titre est déjà présent dans votre bibliothèque. Voulez-vous vraiment ajouter ce livre ?", "Confirmation", MessageBoxButtons.YesNo) == (DialogResult.Yes))
                    {
                        ListeLivres.Add(nouvLivre);
                    }
                }
                // vide le contenu des textboxes
                textBoxTitre.Clear();
                textBoxAuteur.Clear();
                listBox1.SelectedIndex = -1;

                // mise à jour de la listbox
                MajListeLivres();
            }
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            // Supprime les livres sélectionnés de la collection
            List<int> indicesLivresASupprimer = new List<int>();
            int index = 0;
            if (listBox1.SelectedIndex != -1)
            {
                if (MessageBox.Show($"Voulez-vous vraiment supprimer {listBox1.SelectedItems.Count} livre(s) de votre bibliothèque ?", "Confirmation", MessageBoxButtons.YesNo) == (DialogResult.Yes))
                {
                    for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        int indexlist = listBox1.SelectedIndices[i];
                        string currItem = listBox1.Items[indexlist].ToString();
                        foreach (Livre livre in ListeLivres)
                        {
                            string str = livre.GetAuteur().ToString() + ". " + livre.GetTitre().ToString() + ' ' + '[' + livre.GetStatut().ToString() + ']';
                            if (currItem == str)
                            {
                                index = ListeLivres.IndexOf(livre);
                                indicesLivresASupprimer.Add(index);
                            }
                        }
                    }
                    foreach(int indice in indicesLivresASupprimer)
                    {
                        ListeLivres.RemoveAt(indice);
                    }
                    MajListeLivres();
                }
            }
        }
        
        private void BtnKeepBook_Click(object sender, EventArgs e)
        {
            // Change le statut du livre à "Conserver"
            ChangeStatutLivreSelectionnes("Conserver");
        }

        private void BtnGiveBook_Click(object sender, EventArgs e)
        {
            // Change le statut du livre à "Donner"
            ChangeStatutLivreSelectionnes("Donner");
        }

        private void BtnBookSell_Click(object sender, EventArgs e)
        {
            // Change le statut du livre à "Vendre"
            ChangeStatutLivreSelectionnes("Vendre");
        }

        private void BtnRecycleBook_Click(object sender, EventArgs e)
        {
            // Change le statut du livre à "Recycler"
            ChangeStatutLivreSelectionnes("Recycler");
        }

        private void BtnApplyBookModification_Click(object sender, EventArgs e)
        {
            // applique les modifications saisies sur le livre
            if (listBox1.SelectedIndex != -1)
            {
                string unTitre = textBoxTitre.Text;
                string unAuteur = textBoxAuteur.Text;
                string unStatut = comboBoxStatut.SelectedItem.ToString();
                Livre unLivre = ListeLivres[RecupIndexListeLivres()];
                unLivre.SetAuteur(textBoxAuteur.Text.ToUpper());
                unLivre.SetTitre(textBoxTitre.Text);
                unLivre.SetStatut(comboBoxStatut.Text);
                MajListeLivres();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAuteur.Clear();
            textBoxTitre.Clear();

            // quand aucune ligne n'est sélectionnée, ne pas afficher les informations de l'objet dans les textboxes
            if (listBox1.SelectedIndex == -1)
            {
                textBoxAuteur.Enabled = true;
                textBoxTitre.Enabled = true;
                comboBoxStatut.Enabled = true;
                BtnAddBook.Enabled = true;
                comboBoxStatut.SelectedIndex = 0;
            }

            // quand une ligne est sélectionnée, remplir les textboxes avec les informations du livre sélectionné à partir de ListeLivres
            if (listBox1.SelectedIndex != -1)
            {
                textBoxAuteur.Enabled = true;
                textBoxTitre.Enabled = true;
                comboBoxStatut.Enabled = true;
                BtnAddBook.Enabled = false;
                BtnApplyBookModification.Enabled = true;
                Livre unLivre = ListeLivres[RecupIndexListeLivres()];
                textBoxAuteur.Text = unLivre.GetAuteur().ToString();
                textBoxTitre.Text = unLivre.GetTitre().ToString();
                comboBoxStatut.Text = unLivre.GetStatut().ToString();
            }

            //quand plusieurs lignes sont sélectionnées, ne pas afficher les informations de l'objet dans les textboxes
            if (listBox1.SelectedIndices.Count > 1)
            {
                textBoxAuteur.Clear();
                textBoxTitre.Clear();
                textBoxAuteur.Enabled = false;
                textBoxTitre.Enabled = false;
                comboBoxStatut.Enabled = false;
                BtnAddBook.Enabled = false;
                BtnApplyBookModification.Enabled = false;
                comboBoxStatut.SelectedIndex = 0;
            }
        }

        private void BtnClearTextboxes_Click(object sender, EventArgs e)
        {
            textBoxTitre.Clear();
            textBoxAuteur.Clear();
            comboBoxStatut.SelectedIndex = 0;
            listBox1.SelectedIndex = -1;
        }

        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Livre> ListeFiltreLivres = new List<Livre>();
            listBox1.DataSource = null;
            ListeFiltreLivres.Clear();

            // quand textbox remplie boucler dans la collection pour trouver le livre recherché
            if (string.IsNullOrEmpty(TxtBoxSearch.Text) == false)
            {
                MajListeLivres();
                BtnRConserver.Checked = false;
                BtnRDonner.Checked = false;
                BtnRVendre.Checked = false;
                BtnRRecycler.Checked = false;
                {
                    foreach (Livre livre in ListeLivres)
                    {
                        string auteur = livre.GetAuteur().ToString();
                        string titre = livre.GetTitre().ToString();

                        if (auteur.ToLower().Contains(TxtBoxSearch.Text.ToLower()) | titre.ToLower().Contains(TxtBoxSearch.Text.ToLower()))
                        {
                            ListeFiltreLivres.Add(livre);
                        }
                    }
                    listBox1.DataSource = ListeFiltreLivres;
                }
                listBox1.SelectedIndex = -1;
            }

            if (TxtBoxSearch.Text == "")
            {
                MajListeLivres();
            }
        }

        private void FiltrerLivresStatut(string statut)
        {
            // filtrer les livres selon leur statut
            List<Livre> ListeFiltreLivres = new List<Livre>();
            foreach (Livre livre in ListeLivres)
            {
                if (livre.GetStatut() == statut)
                {
                    ListeFiltreLivres.Add(livre);
                }
            }
            listBox1.DataSource = ListeFiltreLivres;
            listBox1.SelectedIndex = -1;
        }

        private void BtnRDonner_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRDonner.Checked == true)
            {
                FiltrerLivresStatut("Donner");
            }
            listBox1.SelectedIndex = -1;
        }

        private void BtnRConserver_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRConserver.Checked == true)
            {
                FiltrerLivresStatut("Conserver");
            }
            listBox1.SelectedIndex = -1;
        }

        private void BtnRVendre_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRVendre.Checked == true)
            {
                FiltrerLivresStatut("Vendre");
            }
            listBox1.SelectedIndex = -1;
        }

        private void BtnRRecycler_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnRRecycler.Checked == true)
            {
                FiltrerLivresStatut("Recycler");
            }
            listBox1.SelectedIndex = -1;
        }

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            BtnRConserver.Checked = false;
            BtnRDonner.Checked = false;
            BtnRVendre.Checked = false;
            BtnRRecycler.Checked = false;
            TxtBoxSearch.Clear();
            MajListeLivres();
        }

        // au passage de la souris afficher infobulles sur les contrôles de l'interface
        private void BtnKeepBook_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Conserver le livre sélectionné", BtnKeepBook);
        }

        private void BtnGiveBook_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Donner le livre sélectionné", BtnGiveBook);
        }

        private void BtnBookSell_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Vendre le livre sélectionné", BtnBookSell);
        }

        private void BtnRecycleBook_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Recycler le livre sélectionné", BtnRecycleBook);
        }

        private void BtnDeleteBook_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Supprimer le livre sélectionné de votre bibliothèque", BtnDeleteBook);
        }

        private void BtnAddBook_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Ajouter un livre à votre bibliothèque", BtnAddBook);
        }

        private void BtnApplyBookModification_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Appliquer les modifications au livre", BtnApplyBookModification);
        }

        private void BtnClearTextboxes_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Effacer les champs Auteur(Nom) et Titre", BtnClearTextboxes);
        }

        private void BtnClearFilters_MouseHover(object sender, EventArgs e)
        {
            toolTip9.Show("Supprimer tous les filtres", BtnClearFilters);
        }
    }
}
