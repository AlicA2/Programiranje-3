namespace DLWMS.WinForms.IB200087
{
    partial class frmStudentSeminarskiIB200087
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.pbSlikaDonja = new System.Windows.Forms.PictureBox();
            this.lblStranica = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdZaSliku = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaDonja)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLijevo);
            this.groupBox2.Controls.Add(this.btnDesno);
            this.groupBox2.Controls.Add(this.lblOpis);
            this.groupBox2.Controls.Add(this.lblDatum);
            this.groupBox2.Controls.Add(this.pbSlikaDonja);
            this.groupBox2.Controls.Add(this.lblStranica);
            this.groupBox2.Location = new System.Drawing.Point(13, 315);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(567, 400);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pregled seminarskog";
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(12, 164);
            this.btnLijevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(100, 28);
            this.btnLijevo.TabIndex = 8;
            this.btnLijevo.Text = "<==";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(444, 164);
            this.btnDesno.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(100, 28);
            this.btnDesno.TabIndex = 7;
            this.btnDesno.Text = "==>";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(247, 331);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(35, 16);
            this.lblOpis.TabIndex = 6;
            this.lblOpis.Text = "Opis";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(243, 302);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(46, 16);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum";
            // 
            // pbSlikaDonja
            // 
            this.pbSlikaDonja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaDonja.Location = new System.Drawing.Point(145, 54);
            this.pbSlikaDonja.Margin = new System.Windows.Forms.Padding(4);
            this.pbSlikaDonja.Name = "pbSlikaDonja";
            this.pbSlikaDonja.Size = new System.Drawing.Size(263, 243);
            this.pbSlikaDonja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaDonja.TabIndex = 5;
            this.pbSlikaDonja.TabStop = false;
            // 
            // lblStranica
            // 
            this.lblStranica.AutoSize = true;
            this.lblStranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStranica.Location = new System.Drawing.Point(188, 20);
            this.lblStranica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStranica.Name = "lblStranica";
            this.lblStranica.Size = new System.Drawing.Size(114, 31);
            this.lblStranica.TabIndex = 4;
            this.lblStranica.Text = "Stranica";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPredmet.Location = new System.Drawing.Point(193, 47);
            this.lblPredmet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(116, 31);
            this.lblPredmet.TabIndex = 10;
            this.lblPredmet.Text = "Predmet";
            this.lblPredmet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImePrezime.Location = new System.Drawing.Point(193, 16);
            this.lblImePrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(175, 31);
            this.lblImePrezime.TabIndex = 9;
            this.lblImePrezime.Text = "Ime i prezime";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pbSlika);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(567, 220);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(444, 170);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(195, 39);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(348, 109);
            this.txtOpis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(12, 39);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(4);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(170, 158);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            this.pbSlika.DoubleClick += new System.EventHandler(this.pbSlika_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slika:";
            // 
            // ofdZaSliku
            // 
            this.ofdZaSliku.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmStudentSeminarskiIB200087
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudentSeminarskiIB200087";
            this.Text = "frmStudentSeminarskiIB200087";
            this.Load += new System.EventHandler(this.frmStudentSeminarskiIB200087_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaDonja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.PictureBox pbSlikaDonja;
        private System.Windows.Forms.Label lblStranica;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdZaSliku;
        private System.Windows.Forms.ErrorProvider err;
    }
}