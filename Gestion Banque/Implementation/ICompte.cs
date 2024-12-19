using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.entity;

namespace GestionBanque.Implementation
{
    internal interface ICompte
    {
        void AjouterCompte(Compte compte);
        void ConsulterCompte(Compte compte);
        void SupprimerCompte(Compte compte);
        void ModifierCompte(Compte compte, int id);




    }
}
