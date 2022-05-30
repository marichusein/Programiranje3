using DLWMS.WinForms.IspitIB200001.EntitetiIB200001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB200001
{
    public class PomocnaKlasaZaFormuIB200001
    {
        public PomocnaKlasaZaFormuIB200001(Student s)
        {
            Id = s.Id;
            ImePrezime = s.Ime + " " + s.Prezime;
            int brojac = 0; double suma = 0.0;
            var listaPredmeta = new List<PredmetiIB200001>();
            foreach (var predmet in s.PredmetiS)
            {
                listaPredmeta.Add(predmet.Predmet);
                brojac++;
                suma += predmet.Ocjena;
            }
            if (brojac > 0)
            {
                Prosjek = suma / brojac;
                BrojPolozenih = brojac;
                Polozeni = String.Join(";", listaPredmeta);
            }
            else
            {
                Prosjek = 0;
                Polozeni = "B R U C O S";
            }
            var listaUloga = new List<UlogeIB200001>();
            foreach (var item in s.studentiUloge)
            {
                listaUloga.Add(item.Uloge);
            }
            if (listaUloga.Count > 0)
            {
                Uloga = String.Join(";", listaUloga);
            }
            else
            {
                Uloga = "OBICNI_STUDENT";
            }
            Spol = s.Spol.Naziv;
        }
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Polozeni { get; set; }
        public int BrojPolozenih { get; set; }
        public double Prosjek { get; set; }
        public string Uloga { get; set; }
        public string Spol { get; set; }
    }
}
