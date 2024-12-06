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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBookSell = new System.Windows.Forms.Button();
            this.BtnGiveBook = new System.Windows.Forms.Button();
            this.BtnKeepBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNumberBooksSell = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNumberofBooks = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.comboBoxStatut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.textBoxAuteur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GestionBibliotheque.Properties.Resources.left_pointing_magnifying_glass_256x256;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(345, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 0;
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
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.radioButton1.Location = new System.Drawing.Point(15, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tous les livres";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBookSell);
            this.panel1.Controls.Add(this.BtnGiveBook);
            this.panel1.Controls.Add(this.BtnKeepBook);
            this.panel1.Controls.Add(this.BtnDeleteBook);
            this.panel1.Location = new System.Drawing.Point(367, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 228);
            this.panel1.TabIndex = 3;
            // 
            // BtnBookSell
            // 
            this.BtnBookSell.BackgroundImage = global::GestionBibliotheque.Properties.Resources.hand_coin_euro_finance_icon_125508;
            this.BtnBookSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBookSell.Location = new System.Drawing.Point(0, 188);
            this.BtnBookSell.Name = "BtnBookSell";
            this.BtnBookSell.Size = new System.Drawing.Size(40, 40);
            this.BtnBookSell.TabIndex = 10;
            this.BtnBookSell.UseVisualStyleBackColor = true;
            this.BtnBookSell.Click += new System.EventHandler(this.BtnBookSell_Click);
            // 
            // BtnGiveBook
            // 
            this.BtnGiveBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.iconfinder_giftbooksurprisepresent_3992482_112617;
            this.BtnGiveBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGiveBook.Location = new System.Drawing.Point(0, 122);
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
            this.BtnKeepBook.Location = new System.Drawing.Point(0, 62);
            this.BtnKeepBook.Name = "BtnKeepBook";
            this.BtnKeepBook.Size = new System.Drawing.Size(40, 40);
            this.BtnKeepBook.TabIndex = 10;
            this.BtnKeepBook.UseVisualStyleBackColor = true;
            this.BtnKeepBook.Click += new System.EventHandler(this.BtnKeepBook_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackgroundImage = global::GestionBibliotheque.Properties.Resources.gui_action_delete_254x256;
            this.BtnDeleteBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteBook.Location = new System.Drawing.Point(0, 0);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(40, 40);
            this.BtnDeleteBook.TabIndex = 10;
            this.BtnDeleteBook.UseVisualStyleBackColor = true;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Livres :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.LblNumberBooksSell);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblNumberofBooks);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 28);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LblNumberBooksSell
            // 
            this.LblNumberBooksSell.AutoSize = true;
            this.LblNumberBooksSell.Location = new System.Drawing.Point(200, 10);
            this.LblNumberBooksSell.Name = "LblNumberBooksSell";
            this.LblNumberBooksSell.Size = new System.Drawing.Size(0, 13);
            this.LblNumberBooksSell.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "A donner :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "A vendre :";
            // 
            // LblNumberofBooks
            // 
            this.LblNumberofBooks.AutoSize = true;
            this.LblNumberofBooks.Location = new System.Drawing.Point(46, 9);
            this.LblNumberofBooks.Name = "LblNumberofBooks";
            this.LblNumberofBooks.Size = new System.Drawing.Size(0, 13);
            this.LblNumberofBooks.TabIndex = 8;
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
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            this.comboBoxStatut.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(67, 57);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(318, 20);
            this.textBoxTitre.TabIndex = 14;
            // 
            // textBoxAuteur
            // 
            this.textBoxAuteur.Location = new System.Drawing.Point(67, 26);
            this.textBoxAuteur.Name = "textBoxAuteur";
            this.textBoxAuteur.Size = new System.Drawing.Size(318, 20);
            this.textBoxAuteur.TabIndex = 13;
            this.textBoxAuteur.TextChanged += new System.EventHandler(this.textBoxAuteur_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Auteur";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}