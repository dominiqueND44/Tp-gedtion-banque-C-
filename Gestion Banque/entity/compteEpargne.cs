using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.entity
{
    internal class compteEpargne : Compte
    {
        
        private int duree;
        public compteEpargne(int duree, int id, string numeroCompte, int solde) : base(id, numeroCompte, solde)
        {
            
        }
        public compteEpargne()
        {
            nbcompte++;
            Id = nbcompte;
        }

        public int Duree
        {
            get { return duree;}
            set { duree = value; }
         }

        public override string ToString() {
            return base.ToString()+ "Duree : "+ duree;
        }
    }
}
