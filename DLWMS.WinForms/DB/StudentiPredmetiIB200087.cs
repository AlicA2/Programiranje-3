using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB200087
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetiIB200087 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }
}
