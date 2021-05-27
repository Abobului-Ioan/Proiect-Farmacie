
namespace InterfataUtilizatorForms
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridMedicament = new System.Windows.Forms.DataGridView();
            this.txtNume2 = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.buttonCauta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Click pentru a te intoarce";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridMedicament
            // 
            this.dataGridMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicament.Location = new System.Drawing.Point(11, 142);
            this.dataGridMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMedicament.Name = "dataGridMedicament";
            this.dataGridMedicament.RowHeadersWidth = 51;
            this.dataGridMedicament.RowTemplate.Height = 24;
            this.dataGridMedicament.Size = new System.Drawing.Size(778, 160);
            this.dataGridMedicament.TabIndex = 8;
            // 
            // txtNume2
            // 
            this.txtNume2.Location = new System.Drawing.Point(307, 63);
            this.txtNume2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNume2.Name = "txtNume2";
            this.txtNume2.Size = new System.Drawing.Size(189, 20);
            this.txtNume2.TabIndex = 7;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(304, 48);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(206, 13);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Introduceti numele medicamentului cautat:";
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(343, 101);
            this.buttonCauta.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(98, 24);
            this.buttonCauta.TabIndex = 5;
            this.buttonCauta.Text = "Cauta medicament";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridMedicament);
            this.Controls.Add(this.txtNume2);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.buttonCauta);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridMedicament;
        private System.Windows.Forms.TextBox txtNume2;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button buttonCauta;
    }
}