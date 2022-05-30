using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB200001.EntitetiIB200001
{
    [Table("StudentiPotvrde")]
    public class StudentiPotvrdeIB200001
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public string Svrha { get; set; }
        public DateTime Datum { get; set; }
        public bool Izdata { get; set; }
    }
}
