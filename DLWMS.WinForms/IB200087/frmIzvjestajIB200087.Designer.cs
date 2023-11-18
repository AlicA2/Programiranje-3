namespace DLWMS.WinForms.IB200087
{
    partial class frmIzvjestajIB200087
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
            this.rptIzvjestaj = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptIzvjestaj
            // 
            this.rptIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptIzvjestaj.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.IB200087.rptIzvjestajIB200087.rdlc";
            this.rptIzvjestaj.Location = new System.Drawing.Point(0, 0);
            this.rptIzvjestaj.Name = "rptIzvjestaj";
            this.rptIzvjestaj.ServerReport.BearerToken = null;
            this.rptIzvjestaj.Size = new System.Drawing.Size(800, 450);
            this.rptIzvjestaj.TabIndex = 0;
            // 
            // frmIzvjestajIB200087
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptIzvjestaj);
            this.Name = "frmIzvjestajIB200087";
            this.Text = "frmIzvjestajIB200087";
            this.Load += new System.EventHandler(this.frmIzvjestajIB200087_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptIzvjestaj;
    }
}