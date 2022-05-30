
using System.Data.Entity;
using DLWMS.WinForms.IspitIB200001.EntitetiIB200001;
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
        public DbSet<SpolIB200001> Spol { get; set; }
        public DbSet<PredmetiIB200001> Predmet { get; set; }
        public DbSet<UlogeIB200001> Uloge { get; set; }
        public DbSet<StudentiPredmetiIB200001> StudentiPredmeti { get; set; }
        public DbSet<StudentiPotvrdeIB200001> StudentiPotvrde { get; set; }
        public DbSet<StudentiUloge> StudentiUloge { get; set; }
        public DbSet<Student> Studenti { get; set; }
       
    }
}