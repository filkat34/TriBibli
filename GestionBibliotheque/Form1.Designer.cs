namespace GestionBibliotheque
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNumberBooksSell = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNumberofBooks = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.textBoxAuteur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNbBooksToSell = new System.Windows.Forms.Label();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnRecycleBook = new System.Windows.Forms.Button();
            this.BtnBookSell = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnGiveBook = new System.Windows.Forms.Button();
            this.BtnKeepBook = new System.Windows.Forms.Button();
            this.LblNbBooksToGive = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblNbBooksToRecycle = new System.Windows.Forms.Label();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 265);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 228);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrer";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(128, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Conserver";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(326, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Vendre";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(232, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Donner";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tous les livres";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRecycleBook);
            this.panel1.Controls.Add(this.BtnBookSell);
            this.panel1.Controls.Add(this.BtnDeleteBook);
            this.panel1.Controls.Add(this.BtnGiveBook);
            this.panel1.Controls.Add(this.BtnKeepBook);
            this.panel1.Location = new System.Drawing.Point(367, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 228);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Livres :";
            // 
            // panel2
            // 
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.LblNbBooksToRecycle);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.LblNbBooksToGive);
            this.panel2.Controls.Add(this.LblNbBooksToSell);
            this.panel2.Controls.Add(this.LblNumberBooksSell);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblNumberofBooks);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 28);
            this.panel2.TabIndex = 8;
            // 
            // LblNumberBooksSell
            // 
            this.LblNumberBooksSell.AutoSize = true;
            this.LblNumberBooksSell.Location = new System.Drawing.Point(220, 10);
            this.LblNumberBooksSell.Name = "LblNumberBooksSell";
            this.LblNumberBooksSell.Size = new System.Drawing.Size(0, 13);
            this.LblNumberBooksSell.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "A donner :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "A vendre :";
            // 
            // LblNumberofBooks
            // 
            this.LblNumberofBooks.AutoSize = true;
            this.LblNumberofBooks.Location = new System.Drawing.Point(55, 9);
            this.LblNumberofBooks.Name = "LblNumberofBooks";
            this.LblNumberofBooks.Size = new System.Drawing.Size(13, 13);
            this.LblNumberofBooks.TabIndex = 8;
            this.LblNumberofBooks.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddBook);
            this.groupBox3.Controls.Add(this.comboBoxStatut);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.textBoxTitre);
            this.groupBox3.Controls.Add(this.textBoxAuteur);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 131);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter/Modifier";
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Items.AddRange(new object[] {
            "Conserver",
            "Donner",
            "Vendre"});
            this.comboBoxStatut.Location = new System.Drawing.Point(67, 95);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(197, 21);
            this.comboBoxStatut.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Statut";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(58, 57);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(327, 20);
            this.textBoxTitre.TabIndex = 14;
            // 
            // textBoxAuteur
            // 
            this.textBoxAuteur.Location = new System.Drawing.Point(87, 26);
            this.textBoxAuteur.Name = "textBoxAuteur";
            this.textBoxAuteur.Size = new System.Drawing.Size(298, 20);
            this.textBoxAuteur.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Auteur (Nom)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Titre";
            // 
            // LblNbBooksToSell
            // 
            this.LblNbBooksToSell.AutoSize = true;
            this.LblNbBooksToSell.Location = new System.Drawing.Point(160, 9);
            this.LblNbBooksToSell.Name = "LblNbBooksToSell";
            this.LblNbBooksToSell.Size = new System.Drawing.Size(13, 13);
            this.LblNbBooksToSell.TabIndex = 12;
            this.LblNbBooksToSell.Text = "0";
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.plus_256x256;
            this.BtnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddBook.Location = new System.Drawing.Point(299, 83);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(40, 40);
            this.BtnAddBook.TabIndex = 17;
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(345, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnRecycleBook
            // 
            this.BtnRecycleBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.recycle_77943;
            this.BtnRecycleBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRecycleBook.Location = new System.Drawing.Point(0, 138);
            this.BtnRecycleBook.Name = "BtnRecycleBook";
            this.BtnRecycleBook.Size = new System.Drawing.Size(40, 40);
            this.BtnRecycleBook.TabIndex = 10;
            this.BtnRecycleBook.UseVisualStyleBackColor = true;
            this.BtnRecycleBook.Click += new System.EventHandler(this.BtnRecycleBook_Click);
            // 
            // BtnBookSell
            // 
            this.BtnBookSell.BackgroundImage = global::GestionBibliotheque.Properties.Resources.hand_coin_euro_finance_icon_125508;
            this.BtnBookSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBookSell.Location = new System.Drawing.Point(0, 92);
            this.BtnBookSell.Name = "BtnBookSell";
            this.BtnBookSell.Size = new System.Drawing.Size(40, 40);
            this.BtnBookSell.TabIndex = 10;
            this.BtnBookSell.UseVisualStyleBackColor = true;
            this.BtnBookSell.Click += new System.EventHandler(this.BtnBookSell_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.gui_action_delete_254x256;
            this.BtnDeleteBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteBook.Location = new System.Drawing.Point(0, 184);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(40, 40);
            this.BtnDeleteBook.TabIndex = 10;
            this.BtnDeleteBook.UseVisualStyleBackColor = true;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnGiveBook
            // 
            this.BtnGiveBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.gift_icon_34411;
            this.BtnGiveBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGiveBook.Location = new System.Drawing.Point(0, 46);
            this.BtnGiveBook.Name = "BtnGiveBook";
            this.BtnGiveBook.Size = new System.Drawing.Size(40, 40);
            this.BtnGiveBook.TabIndex = 10;
            this.BtnGiveBook.UseVisualStyleBackColor = true;
            this.BtnGiveBook.Click += new System.EventHandler(this.BtnGiveBook_Click);
            // 
            // BtnKeepBook
            // 
            this.BtnKeepBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.bookshelf_icon_icons_com_54414;
            this.BtnKeepBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKeepBook.Location = new System.Drawing.Point(0, 0);
            this.BtnKeepBook.Name = "BtnKeepBook";
            this.BtnKeepBook.Size = new System.Drawing.Size(40, 40);
            this.BtnKeepBook.TabIndex = 10;
            this.BtnKeepBook.UseVisualStyleBackColor = true;
            this.BtnKeepBook.Click += new System.EventHandler(this.BtnKeepBook_Click);
            // 
            // LblNbBooksToGive
            // 
            this.LblNbBooksToGive.AutoSize = true;
            this.LblNbBooksToGive.Location = new System.Drawing.Point(249, 10);
            this.LblNbBooksToGive.Name = "LblNbBooksToGive";
            this.LblNbBooksToGive.Size = new System.Drawing.Size(13, 13);
            this.LblNbBooksToGive.TabIndex = 13;
            this.LblNbBooksToGive.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "A recycler :";
            // 
            // LblNbBooksToRecycle
            // 
            this.LblNbBooksToRecycle.AutoSize = true;
            this.LblNbBooksToRecycle.Location = new System.Drawing.Point(345, 9);
            this.LblNbBooksToRecycle.Name = "LblNbBooksToRecycle";
            this.LblNbBooksToRecycle.Size = new System.Drawing.Size(13, 13);
            this.LblNbBooksToRecycle.TabIndex = 15;
            this.LblNbBooksToRecycle.Text = "0";
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Location = new System.Drawing.Point(7, 20);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(378, 20);
            this.TxtBoxSearch.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Gestionnaire de bibliothèque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.TextBox textBoxAuteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxStatut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnKeepBook;
        private System.Windows.Forms.Button BtnGiveBook;
        private System.Windows.Forms.Button BtnBookSell;
        private System.Windows.Forms.Label LblNumberofBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNumberBooksSell;
        private System.Windows.Forms.Button BtnRecycleBook;
        private System.Windows.Forms.Label LblNbBooksToSell;
        private System.Windows.Forms.Label LblNbBooksToGive;
        private System.Windows.Forms.Label LblNbBooksToRecycle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoxSearch;
    }
}