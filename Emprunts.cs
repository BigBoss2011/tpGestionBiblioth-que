﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpGestionBibliothèque
{
    class Emprunts
    {
        //public List<Emprunt> lstEmprunts { get; set; }
        //public Emprunts()
        //{
        //    lstEmprunts = new List<Emprunt>();
        //}
        //or simply
        public List<Emprunt> lstEmprunts { get; set; } = new List<Emprunt>();
        public bool Add(Emprunt Ep)
        {
            if (lstEmprunts.Contains(Ep))
                return false;

            lstEmprunts.Add(Ep);
            return true;
        }
    }
}
