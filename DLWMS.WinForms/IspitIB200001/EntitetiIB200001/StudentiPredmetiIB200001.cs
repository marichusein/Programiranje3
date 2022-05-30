﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB200001.EntitetiIB200001
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB200001
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetiIB200001 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public override string ToString()
        {
            return $"{Student.Ime}";
        }
    }
}
