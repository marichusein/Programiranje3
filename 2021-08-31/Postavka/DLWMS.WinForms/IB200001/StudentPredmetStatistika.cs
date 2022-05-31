using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200001
{
    
    public class StudentPredmetStatistika
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;

        public StudentPredmetStatistika(Student student)
        {
            ID = student.Id;
            ImePrezime = student.Ime + " " + student.Prezime;
            var ListaPredmeta = new List<Predmet>();
            int brojac = 0;
            double suma = 0;
            foreach (var predmet in db.StudentiPredmeti)
            {
               
                if (student.Id == predmet.Student.Id)
                {
                    ListaPredmeta.Add(predmet.Predmet);
                    suma += predmet.Ocjena;
                    brojac++;
                }
            }
            PolozeniPredmeti = String.Join(";", ListaPredmeta);
            if (suma > 0)
            {
                Prosjek = suma / brojac;
            }
            else
            {
                Prosjek = 0.0;
            }
            BrojPredmeta = brojac;
        }
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public string PolozeniPredmeti { get; set; }
        public double Prosjek { get; set; }
        public int BrojPredmeta { get; set; }


    }
}
