using DLWMS.WinForms.DB;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200087
{
    public partial class frmIzvjestajIB200087 : Form
    {
        private List<StudentiPredmetiIB200087> listaStudenata;
        public frmIzvjestajIB200087(List<StudentiPredmetiIB200087> listaStudenata)
        {
            InitializeComponent();
            this.listaStudenata = listaStudenata;
        }

        private void frmIzvjestajIB200087_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource();
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("BrojPolozenih", listaStudenata.Count.ToString()));
            rpc.Add(new ReportParameter("Prosjecna", listaStudenata.Average(o => o.Ocjena).ToString()));

            var tbl = new dsIzvjestajIB200087.DataTable1DataTable();
            foreach (var s in listaStudenata)
            {
                var red = tbl.NewDataTable1Row();
                red.Rb = s.Id.ToString();
                red.ImePrezime = s.Student.ToString();
                red.Predmet = s.Predmet.ToString();
                red.Datum = s.DatumPolaganja.ToString();
                red.Ocjena = s.Ocjena.ToString();
                tbl.AddDataTable1Row(red);
            }
            rds.Value = tbl;
            rds.Name = "dsStudenti";

            this.rptIzvjestaj.LocalReport.DataSources.Add(rds);
            this.rptIzvjestaj.LocalReport.SetParameters(rpc);
            this.rptIzvjestaj.RefreshReport();
        }
    }
}
