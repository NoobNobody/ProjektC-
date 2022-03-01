namespace WindowsFormsApp1
{
    partial class AddMember
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.imie = new System.Windows.Forms.TextBox();
            this.plec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.wiek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.oplata = new System.Windows.Forms.TextBox();
            this.czas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // imie
            // 
            this.imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.Location = new System.Drawing.Point(65, 280);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(162, 49);
            this.imie.TabIndex = 0;
            // 
            // plec
            // 
            this.plec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plec.FormattingEnabled = true;
            this.plec.Items.AddRange(new object[] {
            "Mezczyzna ",
            "Kobieta"});
            this.plec.Location = new System.Drawing.Point(65, 652);
            this.plec.Name = "plec";
            this.plec.Size = new System.Drawing.Size(167, 45);
            this.plec.TabIndex = 1;
            this.plec.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siłownia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dodaj członka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 60);
            this.label4.TabIndex = 5;
            this.label4.Text = "Płeć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(967, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 60);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wiek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 60);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefon";
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefon.Location = new System.Drawing.Point(509, 280);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(190, 49);
            this.telefon.TabIndex = 8;
            // 
            // wiek
            // 
            this.wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wiek.Location = new System.Drawing.Point(977, 280);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(114, 49);
            this.wiek.TabIndex = 9;
            this.wiek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wiek_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 60);
            this.label7.TabIndex = 10;
            this.label7.Text = "Termin wejścia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(442, 60);
            this.label8.TabIndex = 11;
            this.label8.Text = "Miesięczna opłata";
            // 
            // oplata
            // 
            this.oplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oplata.Location = new System.Drawing.Point(509, 472);
            this.oplata.Name = "oplata";
            this.oplata.Size = new System.Drawing.Size(190, 49);
            this.oplata.TabIndex = 12;
            this.oplata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oplata_KeyPress);
            // 
            // czas
            // 
            this.czas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.FormattingEnabled = true;
            this.czas.Items.AddRange(new object[] {
            "6-10",
            "10-14",
            "14-18",
            "18-22"});
            this.czas.Location = new System.Drawing.Point(960, 476);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(167, 45);
            this.czas.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(923, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "Strona główna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(696, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 64);
            this.button2.TabIndex = 15;
            this.button2.Text = "Resetuj";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(450, 633);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 64);
            this.button3.TabIndex = 16;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Eras Medium ITC", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 60);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nazwisko";
            // 
            // nazwisko
            // 
            this.nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko.Location = new System.Drawing.Point(65, 472);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(162, 49);
            this.nazwisko.TabIndex = 18;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 901);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.oplata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plec);
            this.Controls.Add(this.imie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMember";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox czas;
        private System.Windows.Forms.TextBox oplata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox wiek;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox plec;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label label9;
    }
}