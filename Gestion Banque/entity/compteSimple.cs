using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.entity
{
    internal class compteSimple:Compte 
    {
        private int tauxdecouvert;

        public compteSimple(int tauxdecouvert, int id, string numeroCompte, int solde):base(id, numeroCompte, solde)
        {
            this.tauxdecouvert = tauxdecouvert;
        }

        public compteSimple()
        {
            nbcompte++;
            Id=nbcompte;
        }

        public int Tauxdecouvert { get; set; }

        public override string ToString()
        {
            return base.ToString() + "Tauxdecouvert" + tauxdecouvert;
        }
    }
}
