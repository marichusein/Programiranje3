﻿
using DLWMS.WinForms.IspitIB200001.EntitetiIB200001;
using System;
using System.Collections.Generic;

namespace DLWMS.WinForms
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public int GodinaStudija { get; set; }
        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        public virtual List<StudentiPredmetiIB200001> PredmetiS {get;set;}
        public virtual List<StudentiPotvrdeIB200001> StudentiPotvrde { get; set; }
        public virtual List<StudentiUloge> studentiUloge { get; set; }
        public virtual SpolIB200001 Spol { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}