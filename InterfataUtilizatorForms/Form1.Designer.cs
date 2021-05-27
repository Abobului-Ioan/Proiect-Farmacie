
namespace InterfataUtilizatorForms
{
    partial class Form1
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelGramaj = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textGramaj = new System.Windows.Forms.TextBox();
            this.textPret = new System.Windows.Forms.TextBox();
            this.textDataExpirare = new System.Windows.Forms.TextBox();
            this.gpbTipAdministrare = new System.Windows.Forms.GroupBox();
            this.rdbSupozitor = new System.Windows.Forms.RadioButton();
            this.rdbInhalator = new System.Windows.Forms.RadioButton();
            this.rdbInjectabil = new System.Windows.Forms.RadioButton();
            this.rdbCapsule = new System.Windows.Forms.RadioButton();
            this.rdbLichid = new System.Windows.Forms.RadioButton();
            this.gpbTipMedicament = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afisareListeiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareMedicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareMedicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereMedicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaMedicamente = new System.Windows.Forms.ListBox();
            this.gpbTipAdministrare.SuspendLayout();
            this.gpbTipMedicament.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 30);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(12, 59);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume";
            // 
            // labelGramaj
            // 
            this.labelGramaj.AutoSize = true;
            this.labelGramaj.Location = new System.Drawing.Point(12, 86);
            this.labelGramaj.Name = "labelGramaj";
            this.labelGramaj.Size = new System.Drawing.Size(40, 13);
            this.labelGramaj.TabIndex = 2;
            this.labelGramaj.Text = "Gramaj";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(12, 113);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(26, 13);
            this.labelPret.TabIndex = 3;
            this.labelPret.Text = "Pret";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 141);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(66, 13);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data expirari";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(88, 27);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(47, 20);
            this.textId.TabIndex = 5;
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(88, 56);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 6;
            // 
            // textGramaj
            // 
            this.textGramaj.Location = new System.Drawing.Point(88, 86);
            this.textGramaj.Name = "textGramaj";
            this.textGramaj.Size = new System.Drawing.Size(100, 20);
            this.textGramaj.TabIndex = 7;
            // 
            // textPret
            // 
            this.textPret.Location = new System.Drawing.Point(88, 113);
            this.textPret.Name = "textPret";
            this.textPret.Size = new System.Drawing.Size(100, 20);
            this.textPret.TabIndex = 8;
            // 
            // textDataExpirare
            // 
            this.textDataExpirare.Location = new System.Drawing.Point(88, 141);
            this.textDataExpirare.Name = "textDataExpirare";
            this.textDataExpirare.Size = new System.Drawing.Size(100, 20);
            this.textDataExpirare.TabIndex = 9;
            // 
            // gpbTipAdministrare
            // 
            this.gpbTipAdministrare.Controls.Add(this.rdbSupozitor);
            this.gpbTipAdministrare.Controls.Add(this.rdbInhalator);
            this.gpbTipAdministrare.Controls.Add(this.rdbInjectabil);
            this.gpbTipAdministrare.Controls.Add(this.rdbCapsule);
            this.gpbTipAdministrare.Controls.Add(this.rdbLichid);
            this.gpbTipAdministrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipAdministrare.Location = new System.Drawing.Point(12, 178);
            this.gpbTipAdministrare.Name = "gpbTipAdministrare";
            this.gpbTipAdministrare.Size = new System.Drawing.Size(103, 138);
            this.gpbTipAdministrare.TabIndex = 13;
            this.gpbTipAdministrare.TabStop = false;
            this.gpbTipAdministrare.Text = "Tip Administrare:";
            this.gpbTipAdministrare.Enter += new System.EventHandler(this.gpbTipAdministrare_Enter);
            // 
            // rdbSupozitor
            // 
            this.rdbSupozitor.AutoSize = true;
            this.rdbSupozitor.Location = new System.Drawing.Point(7, 115);
            this.rdbSupozitor.Name = "rdbSupozitor";
            this.rdbSupozitor.Size = new System.Drawing.Size(69, 17);
            this.rdbSupozitor.TabIndex = 4;
            this.rdbSupozitor.TabStop = true;
            this.rdbSupozitor.Text = "Supozitor";
            this.rdbSupozitor.UseVisualStyleBackColor = true;
            // 
            // rdbInhalator
            // 
            this.rdbInhalator.AutoSize = true;
            this.rdbInhalator.Location = new System.Drawing.Point(7, 87);
            this.rdbInhalator.Name = "rdbInhalator";
            this.rdbInhalator.Size = new System.Drawing.Size(66, 17);
            this.rdbInhalator.TabIndex = 3;
            this.rdbInhalator.TabStop = true;
            this.rdbInhalator.Text = "Inhalator";
            this.rdbInhalator.UseVisualStyleBackColor = true;
            // 
            // rdbInjectabil
            // 
            this.rdbInjectabil.AutoSize = true;
            this.rdbInjectabil.Location = new System.Drawing.Point(7, 64);
            this.rdbInjectabil.Name = "rdbInjectabil";
            this.rdbInjectabil.Size = new System.Drawing.Size(67, 17);
            this.rdbInjectabil.TabIndex = 2;
            this.rdbInjectabil.TabStop = true;
            this.rdbInjectabil.Text = "Injectabil";
            this.rdbInjectabil.UseVisualStyleBackColor = true;
            // 
            // rdbCapsule
            // 
            this.rdbCapsule.AutoSize = true;
            this.rdbCapsule.Location = new System.Drawing.Point(6, 43);
            this.rdbCapsule.Name = "rdbCapsule";
            this.rdbCapsule.Size = new System.Drawing.Size(63, 17);
            this.rdbCapsule.TabIndex = 1;
            this.rdbCapsule.TabStop = true;
            this.rdbCapsule.Text = "Capsule";
            this.rdbCapsule.UseVisualStyleBackColor = true;
            // 
            // rdbLichid
            // 
            this.rdbLichid.AutoSize = true;
            this.rdbLichid.Location = new System.Drawing.Point(7, 20);
            this.rdbLichid.Name = "rdbLichid";
            this.rdbLichid.Size = new System.Drawing.Size(53, 17);
            this.rdbLichid.TabIndex = 0;
            this.rdbLichid.TabStop = true;
            this.rdbLichid.Text = "Lichid";
            this.rdbLichid.UseVisualStyleBackColor = true;
            // 
            // gpbTipMedicament
            // 
            this.gpbTipMedicament.Controls.Add(this.checkBox5);
            this.gpbTipMedicament.Controls.Add(this.checkBox4);
            this.gpbTipMedicament.Controls.Add(this.checkBox3);
            this.gpbTipMedicament.Controls.Add(this.checkBox2);
            this.gpbTipMedicament.Controls.Add(this.checkBox1);
            this.gpbTipMedicament.Location = new System.Drawing.Point(128, 178);
            this.gpbTipMedicament.Name = "gpbTipMedicament";
            this.gpbTipMedicament.Size = new System.Drawing.Size(115, 138);
            this.gpbTipMedicament.TabIndex = 14;
            this.gpbTipMedicament.TabStop = false;
            this.gpbTipMedicament.Text = "Tip Medicament:";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 97);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Antibiotic";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 77);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Durere stomac";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Tuse";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Febra";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Durere cap";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareListeiToolStripMenuItem,
            this.adaugareMedicamentToolStripMenuItem,
            this.modificareToolStripMenuItem,
            this.cautareMedicamentToolStripMenuItem,
            this.stergereMedicamentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afisareListeiToolStripMenuItem
            // 
            this.afisareListeiToolStripMenuItem.Name = "afisareListeiToolStripMenuItem";
            this.afisareListeiToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.afisareListeiToolStripMenuItem.Text = "Afisare listei";
            this.afisareListeiToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // adaugareMedicamentToolStripMenuItem
            // 
            this.adaugareMedicamentToolStripMenuItem.Name = "adaugareMedicamentToolStripMenuItem";
            this.adaugareMedicamentToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.adaugareMedicamentToolStripMenuItem.Text = "Adaugare medicament";
            this.adaugareMedicamentToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.modificareToolStripMenuItem.Text = "Modificare ";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // cautareMedicamentToolStripMenuItem
            // 
            this.cautareMedicamentToolStripMenuItem.Name = "cautareMedicamentToolStripMenuItem";
            this.cautareMedicamentToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.cautareMedicamentToolStripMenuItem.Text = "Cautare medicament";
            this.cautareMedicamentToolStripMenuItem.Click += new System.EventHandler(this.cautareMedicamentToolStripMenuItem_Click);
            // 
            // stergereMedicamentToolStripMenuItem
            // 
            this.stergereMedicamentToolStripMenuItem.Name = "stergereMedicamentToolStripMenuItem";
            this.stergereMedicamentToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.stergereMedicamentToolStripMenuItem.Text = "Stergere medicament";
            this.stergereMedicamentToolStripMenuItem.Click += new System.EventHandler(this.stergereMedicamentToolStripMenuItem_Click);
            // 
            // ListaMedicamente
            // 
            this.ListaMedicamente.FormattingEnabled = true;
            this.ListaMedicamente.Location = new System.Drawing.Point(251, 195);
            this.ListaMedicamente.Name = "ListaMedicamente";
            this.ListaMedicamente.Size = new System.Drawing.Size(443, 147);
            this.ListaMedicamente.TabIndex = 19;
            this.ListaMedicamente.SelectedIndexChanged += new System.EventHandler(this.ListaMedicamente_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaMedicamente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gpbTipMedicament);
            this.Controls.Add(this.gpbTipAdministrare);
            this.Controls.Add(this.textDataExpirare);
            this.Controls.Add(this.textPret);
            this.Controls.Add(this.textGramaj);
            this.Controls.Add(this.textNume);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelGramaj);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbTipAdministrare.ResumeLayout(false);
            this.gpbTipAdministrare.PerformLayout();
            this.gpbTipMedicament.ResumeLayout(false);
            this.gpbTipMedicament.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelGramaj;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textGramaj;
        private System.Windows.Forms.TextBox textPret;
        private System.Windows.Forms.TextBox textDataExpirare;
        private System.Windows.Forms.GroupBox gpbTipAdministrare;
        private System.Windows.Forms.RadioButton rdbSupozitor;
        private System.Windows.Forms.RadioButton rdbInhalator;
        private System.Windows.Forms.RadioButton rdbInjectabil;
        private System.Windows.Forms.RadioButton rdbCapsule;
        private System.Windows.Forms.RadioButton rdbLichid;
        private System.Windows.Forms.GroupBox gpbTipMedicament;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afisareListeiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareMedicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareMedicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereMedicamentToolStripMenuItem;
        private System.Windows.Forms.ListBox ListaMedicamente;
    }
}

