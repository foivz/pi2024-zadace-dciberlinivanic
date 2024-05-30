namespace SustavZaUpravljanjeGradskimPrijevozom
{
    partial class FrmDodavanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtBrSjedala = new System.Windows.Forms.TextBox();
            this.txtKilometri = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboZaposlenik = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip autobusa:";
            // 
            // cboTip
            // 
            this.cboTip.FormattingEnabled = true;
            this.cboTip.Location = new System.Drawing.Point(275, 184);
            this.cboTip.Name = "cboTip";
            this.cboTip.Size = new System.Drawing.Size(172, 24);
            this.cboTip.TabIndex = 1;
            this.cboTip.SelectedIndexChanged += new System.EventHandler(this.cboTip_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka autobusa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registracija autobusa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Broj sjedala:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broj kilometara:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(275, 232);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(172, 22);
            this.txtMarka.TabIndex = 8;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(275, 277);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(172, 22);
            this.txtRegistracija.TabIndex = 9;
            // 
            // txtBrSjedala
            // 
            this.txtBrSjedala.Location = new System.Drawing.Point(275, 325);
            this.txtBrSjedala.Name = "txtBrSjedala";
            this.txtBrSjedala.ReadOnly = true;
            this.txtBrSjedala.Size = new System.Drawing.Size(172, 22);
            this.txtBrSjedala.TabIndex = 10;
            // 
            // txtKilometri
            // 
            this.txtKilometri.Location = new System.Drawing.Point(275, 370);
            this.txtKilometri.Name = "txtKilometri";
            this.txtKilometri.Size = new System.Drawing.Size(172, 22);
            this.txtKilometri.TabIndex = 11;
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.Tan;
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(115, 435);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(113, 51);
            this.btnUnesi.TabIndex = 13;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.Tan;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(258, 435);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(113, 51);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Zaposlenik:";
            // 
            // cboZaposlenik
            // 
            this.cboZaposlenik.FormattingEnabled = true;
            this.cboZaposlenik.Location = new System.Drawing.Point(275, 131);
            this.cboZaposlenik.Name = "cboZaposlenik";
            this.cboZaposlenik.Size = new System.Drawing.Size(172, 24);
            this.cboZaposlenik.TabIndex = 16;
            this.cboZaposlenik.SelectedIndexChanged += new System.EventHandler(this.cboTip_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 54);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dodavanje vozila";
            // 
            // FrmDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(530, 538);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboZaposlenik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtKilometri);
            this.Controls.Add(this.txtBrSjedala);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDodavanje";
            this.Text = "Dodavanje vozila";
            this.Load += new System.EventHandler(this.FrmDodavanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtBrSjedala;
        private System.Windows.Forms.TextBox txtKilometri;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnOdustani;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboZaposlenik;
        private System.Windows.Forms.Label label8;
    }
}