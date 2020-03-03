using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    class Livres
    {
        //public List<Livre> lstLivres { get; set; }
        //public Livres()
        //{
        //    lstLivres = new List<Livre>();
        //}
        //or simply
        public List<Livre> lstLivres { get; set; } = new List<Livre>();
        public bool Add(Livre L)
        {
            if(lstLivres.Contains(L))
                return false;
            lstLivres.Add(L);
            return true;
        }

        public List<int> LesCodes()
        {
            List<int> lstCodes = new List<int>();
            foreach (Livre x in lstLivres)
            {
                lstCodes.Add(x.Code);
            }
            return lstCodes;
        }
        public Livre Find(int Code)
        {
            bool trouve = false;
            int i = 0;
            while (i<lstLivres.Count && !trouve)
            {
                if (lstLivres[i].Code == Code)
                {
                    trouve = true;
                }
                else
                    i++;

            }
            if (trouve)
                return lstLivres[i];
            return null;
            //2nd method
          //return lstLivres.Where(x => x.Code == Code).FirstOrDefault();
        }

        public bool Remove(int code)
        {
            
            Livre L = new Livre();
            L.Code = code;
            if (!lstLivres.Contains(L))
                return false;
            lstLivres.Remove(L);
            return true;
        }
        public bool AddEmprunt(int Code)
        {

            Livre l1 = lstLivres.Where(x => x.Code == Code).First<Livre>();
            if (l1 == null)
                return false;
            l1.NbExemplaire--;
            return true;
        }
    }
}
