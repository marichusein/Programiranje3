using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB200001.EntitetiIB200001
{
    [Table("StudentiUloge")]
    public class StudentiUloge
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual UlogeIB200001 Uloge { get; set; }
        public override string ToString()
        {
            return $"{Uloge.Naziv}";
        }
    }
}
