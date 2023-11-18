using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200087
{
    public partial class frmPretragaIB200087 : Form
    {
        int filterOcjena;
        List<StudentiPredmetiIB200087> listaStudenata;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPretragaIB200087()
        {
            InitializeComponent();
            dgvPrikaz.AutoGenerateColumns = false;
        }

        private void frmPretragaIB200087_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            cmbStudent.DataSource = _baza.Studenti.ToList();
        }

        private void UcitajPodatke()
        {
            dgvPrikaz.DataSource = null;
            dgvPrikaz.DataSource = Filtriraj();
        }

        private List<StudentiPredmetiIB200087> Filtriraj()
        {
            listaStudenata = _baza.StudentiPredmeti.Where(o => o.Ocjena >= filterOcjena).ToList();
            this.Text = $"Ukupno zapisa: {listaStudenata.Count()}";
            return listaStudenata;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbOcjena.Text))
            {
                filterOcjena = int.Parse(cmbOcjena.SelectedItem.ToString());
                UcitajPodatke();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBrojOcjena.Text))
            {
                int brojac = int.Parse(txtBrojOcjena.Text);
                var rand = new Random();
                for (int i = 0; i < brojac; i++)
                {
                    Thread.Sleep(100);
                    var noviS = new StudentiPredmetiIB200087
                    {
                        Student = cmbStudent.SelectedItem as Student,
                        Predmet = _baza.Predmeti.ToList().ElementAt(rand.Next(1, 4)),
                        Ocjena = rand.Next(5, 11),
                        DatumPolaganja = DateTime.Now,
                    };
                    _baza.StudentiPredmeti.Add(noviS);
                    Action akcija = () => txtInfo.Text += $"Za {cmbStudent.SelectedItem as Student} dodat polozeni -> {noviS.Predmet.Naziv} ({noviS.Ocjena}) {Environment.NewLine}";
                    BeginInvoke(akcija);
                }
                _baza.SaveChanges();
                UcitajPodatke();
                MessageBox.Show("Dodavanje predmeta završeno");
            }
        }

        private void dgvPrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var _student = dgvPrikaz.SelectedRows[0].DataBoundItem as StudentiPredmetiIB200087;
                var frmSeminarski = new frmStudentSeminarskiIB200087(_student);
                frmSeminarski.Show();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frmI = new frmIzvjestajIB200087(listaStudenata);
            frmI.Show();
        }
    }
}
