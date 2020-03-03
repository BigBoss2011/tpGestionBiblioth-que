using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    class Adhérents
    {
        //public List<Adhérent> lstAdhérents { get; set; }
        //public Adhérents()
        //{
        //    lstAdhérents = new List<Adhérent>();
        //}
        //or simply
        public List<Adhérent> lstAdhérents { get; set; } = new List<Adhérent>();

        public bool Add(Adhérent ad)
        {
            if (lstAdhérents.Contains(ad))
                return false;
            lstAdhérents.Add(ad);
            return true;
        }
        public bool AddEmprunt(int Id)
        {
            
            Adhérent ad=lstAdhérents.Where(x => x.Id == Id).First<Adhérent>();
            if (ad == null)
                return false;
            ad.NbreEmpruntsEnCours++;
            return true;
        }










        public List<int> LesIds()
        {
            List<int> lstIds = new List<int>();
            foreach (Adhérent x in lstAdhérents)
            {
                lstIds.Add(x.Id);
            }
            return lstIds;
        }
        public Adhérent FindById(int Id) => lstAdhérents.Where<Adhérent>(x => x.Id == Id).FirstOrDefault();
    }
}
