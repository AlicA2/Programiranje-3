using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
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
    public partial class frmStudentSeminarskiIB200087 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private StudentiPredmetiIB200087 _student;
        int brojacSlika = 0;
        public frmStudentSeminarskiIB200087(StudentiPredmetiIB200087 student)
        {
            InitializeComponent();
            _student = student;
        }
        private void frmStudentSeminarskiIB200087_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = _student.Student.ToString();
            lblPredmet.Text = _student.Predmet.ToString();
            UcitajSlikuDatumOpis();
        }

        private void UcitajSlikuDatumOpis()
        {
            if (_student.Student.SlikeSeminarskih.Count() != 0)
            {
                var prvaSlika = _student.Student.SlikeSeminarskih[brojacSlika];
                pbSlikaDonja.Image = ImageHelper.FromByteToImage(prvaSlika.Slika);
                UcitajDatumOpis(_student.Student.SlikeSeminarskih[brojacSlika].DatumDodavanja,
                    _student.Student.SlikeSeminarskih[brojacSlika].Opis);
                lblStranica.Text = $"Stranica {brojacSlika + 1}/{_student.Student.SlikeSeminarskih.Count()}";
            }
        }

        private void UcitajDatumOpis(DateTime datumDodavanja, string opis)
        {
            lblDatum.Text = datumDodavanja.ToString();
            lblOpis.Text = opis;
        }

        private void OcistiSadrzaj()
        {
            pbSlika.Image = null;
            txtOpis.Clear();
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtOpis, err, Poruke.ObaveznaVrijednost);
        }
        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (ofdZaSliku.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(ofdZaSliku.FileName);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                _student.Student.SlikeSeminarskih.Add(new PredmetiSeminarskiIB200087
                {
                    Student = _student.Student,
                    Predmet = _student.Predmet,
                    DatumDodavanja = DateTime.Now,
                    Opis = txtOpis.Text,
                    Slika = ImageHelper.FromImageToByte(pbSlika.Image),
                });
                _baza.SaveChanges();
                MessageBox.Show("Slika uspjesno dodana", "Obavijest");
                OcistiSadrzaj();
                UcitajSlikuDatumOpis();
            }
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            var brojac = brojacSlika - 1;
            if (brojac >= 0)
            {
                brojacSlika--;
                pbSlikaDonja.Image = ImageHelper.FromByteToImage(_student.Student.SlikeSeminarskih[brojacSlika].Slika);
                UcitajDatumOpis(_student.Student.SlikeSeminarskih[brojacSlika].DatumDodavanja,
                    _student.Student.SlikeSeminarskih[brojacSlika].Opis);
                lblStranica.Text = $"Stranica {brojacSlika + 1}/{_student.Student.SlikeSeminarskih.Count()}";
            }
            else
            {
                MessageBox.Show("Nema slike", "Obavijest");
            }
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            var brojac = brojacSlika + 1;
            if (brojac <= _student.Student.SlikeSeminarskih.Count() - 1)
            {
                brojacSlika++;
                pbSlikaDonja.Image = ImageHelper.FromByteToImage(_student.Student.SlikeSeminarskih[brojacSlika].Slika);
                UcitajDatumOpis(_student.Student.SlikeSeminarskih[brojacSlika].DatumDodavanja,
                    _student.Student.SlikeSeminarskih[brojacSlika].Opis);
                lblStranica.Text = $"Stranica {brojacSlika + 1}/{_student.Student.SlikeSeminarskih.Count()}";
            }
            else
            {
                MessageBox.Show("Nema slike", "Obavijest");
            }
        }
    }
}
