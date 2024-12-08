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
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRecycleBook = new System.Windows.Forms.Button();
            this.BtnBookSell = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnGiveBook = new System.Windows.Forms.Button();
            this.BtnKeepBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNbBooksToRecycle = new System.Windows.Forms.Label();
            this.LblNbBooksToGive = new System.Windows.Forms.Label();
            this.LblNbBooksToSell = new System.Windows.Forms.Label();
            this.LblNumberofBooks = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnClearTextboxes = new System.Windows.Forms.Button();
            this.BtnApplyBookModification = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.textBoxAuteur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEraseSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 265);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 228);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEraseSearch);
            this.groupBox1.Controls.Add(this.TxtBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Location = new System.Drawing.Point(7, 20);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(320, 20);
            this.TxtBoxSearch.TabIndex = 0;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
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
            this.panel1.Location = new System.Drawing.Point(368, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 232);
            this.panel1.TabIndex = 3;
            // 
            // BtnRecycleBook
            // 
            this.BtnRecycleBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.recycle_77943;
            this.BtnRecycleBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRecycleBook.Location = new System.Drawing.Point(0, 142);
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
            this.BtnBookSell.Location = new System.Drawing.Point(0, 93);
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
            this.BtnDeleteBook.Location = new System.Drawing.Point(0, 188);
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
            this.BtnKeepBook.Tag = "";
            this.BtnKeepBook.UseVisualStyleBackColor = true;
            this.BtnKeepBook.Click += new System.EventHandler(this.BtnKeepBook_Click);
            // 
            // panel2
            // 
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.LblNbBooksToRecycle);
            this.panel2.Controls.Add(this.LblNbBooksToGive);
            this.panel2.Controls.Add(this.LblNbBooksToSell);
            this.panel2.Controls.Add(this.LblNumberofBooks);
            this.panel2.Location = new System.Drawing.Point(12, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 28);
            this.panel2.TabIndex = 8;
            // 
            // LblNbBooksToRecycle
            // 
            this.LblNbBooksToRecycle.AutoSize = true;
            this.LblNbBooksToRecycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNbBooksToRecycle.Location = new System.Drawing.Point(310, 6);
            this.LblNbBooksToRecycle.Name = "LblNbBooksToRecycle";
            this.LblNbBooksToRecycle.Size = new System.Drawing.Size(75, 15);
            this.LblNbBooksToRecycle.TabIndex = 15;
            this.LblNbBooksToRecycle.Text = "A recycler : 0";
            // 
            // LblNbBooksToGive
            // 
            this.LblNbBooksToGive.AutoSize = true;
            this.LblNbBooksToGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNbBooksToGive.Location = new System.Drawing.Point(202, 6);
            this.LblNbBooksToGive.Name = "LblNbBooksToGive";
            this.LblNbBooksToGive.Size = new System.Drawing.Size(72, 15);
            this.LblNbBooksToGive.TabIndex = 13;
            this.LblNbBooksToGive.Text = "A donner : 0";
            // 
            // LblNbBooksToSell
            // 
            this.LblNbBooksToSell.AutoSize = true;
            this.LblNbBooksToSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNbBooksToSell.Location = new System.Drawing.Point(102, 6);
            this.LblNbBooksToSell.Name = "LblNbBooksToSell";
            this.LblNbBooksToSell.Size = new System.Drawing.Size(70, 15);
            this.LblNbBooksToSell.TabIndex = 12;
            this.LblNbBooksToSell.Text = "A vendre : 0";
            // 
            // LblNumberofBooks
            // 
            this.LblNumberofBooks.AutoSize = true;
            this.LblNumberofBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberofBooks.Location = new System.Drawing.Point(4, 6);
            this.LblNumberofBooks.Name = "LblNumberofBooks";
            this.LblNumberofBooks.Size = new System.Drawing.Size(58, 15);
            this.LblNumberofBooks.TabIndex = 8;
            this.LblNumberofBooks.Text = "Livres  : 0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnClearTextboxes);
            this.groupBox3.Controls.Add(this.BtnApplyBookModification);
            this.groupBox3.Controls.Add(this.BtnAddBook);
            this.groupBox3.Controls.Add(this.comboBoxStatut);
            this.groupBox3.Controls.Add(this.label5);
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
            // BtnClearTextboxes
            // 
            this.BtnClearTextboxes.BackgroundImage = global::GestionBibliotheque.Properties.Resources.ic_backspace_128_28206;
            this.BtnClearTextboxes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClearTextboxes.Location = new System.Drawing.Point(252, 83);
            this.BtnClearTextboxes.Name = "BtnClearTextboxes";
            this.BtnClearTextboxes.Size = new System.Drawing.Size(40, 40);
            this.BtnClearTextboxes.TabIndex = 19;
            this.BtnClearTextboxes.UseVisualStyleBackColor = true;
            this.BtnClearTextboxes.Click += new System.EventHandler(this.BtnClearTextboxes_Click);
            // 
            // BtnApplyBookModification
            // 
            this.BtnApplyBookModification.BackgroundImage = global::GestionBibliotheque.Properties.Resources._1486564391_compose_81525;
            this.BtnApplyBookModification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnApplyBookModification.Location = new System.Drawing.Point(345, 83);
            this.BtnApplyBookModification.Name = "BtnApplyBookModification";
            this.BtnApplyBookModification.Size = new System.Drawing.Size(40, 40);
            this.BtnApplyBookModification.TabIndex = 18;
            this.BtnApplyBookModification.UseVisualStyleBackColor = true;
            this.BtnApplyBookModification.Click += new System.EventHandler(this.BtnApplyBookModification_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.plus_256x256;
            this.BtnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddBook.Location = new System.Drawing.Point(299, 83);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(40, 40);
            this.BtnAddBook.TabIndex = 17;
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // comboBoxStatut
            // 
            this.comboBoxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatut.FormattingEnabled = true;
            this.comboBoxStatut.Items.AddRange(new object[] {
            "Conserver",
            "Donner",
            "Vendre"});
            this.comboBoxStatut.Location = new System.Drawing.Point(58, 94);
            this.comboBoxStatut.Name = "comboBoxStatut";
            this.comboBoxStatut.Size = new System.Drawing.Size(163, 21);
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
            // BtnEraseSearch
            // 
            this.BtnEraseSearch.BackgroundImage = global::GestionBibliotheque.Properties.Resources.ic_backspace_128_28206;
            this.BtnEraseSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEraseSearch.Location = new System.Drawing.Point(345, 12);
            this.BtnEraseSearch.Name = "BtnEraseSearch";
            this.BtnEraseSearch.Size = new System.Drawing.Size(40, 40);
            this.BtnEraseSearch.TabIndex = 1;
            this.BtnEraseSearch.UseVisualStyleBackColor = true;
            this.BtnEraseSearch.Click += new System.EventHandler(this.BtnEraseSearch_Click);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.TextBox textBoxAuteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button BtnRecycleBook;
        private System.Windows.Forms.Label LblNbBooksToSell;
        private System.Windows.Forms.Label LblNbBooksToGive;
        private System.Windows.Forms.Label LblNbBooksToRecycle;
        private System.Windows.Forms.TextBox TxtBoxSearch;
        private System.Windows.Forms.Button BtnApplyBookModification;
        private System.Windows.Forms.Button BtnClearTextboxes;
        private System.Windows.Forms.Button BtnEraseSearch;
    }
}