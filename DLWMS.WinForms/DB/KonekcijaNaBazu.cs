
using System.Data.Entity;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Studenti");                      
        }       
        public DbSet<Student> Studenti { get; set; }
        public DbSet<StudentiPredmetiIB200087> StudentiPredmeti { get; set; }
        public DbSet<PredmetiIB200087> Predmeti { get; set; }
        public DbSet<PredmetiSeminarskiIB200087> PredmetiSeminarski { get; set; }
    }
}