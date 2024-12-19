using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.entity;

namespace GestionBanque.Implementation
{
    internal interface IAgence
    {
        void AjouterAgence(Agence agence);
        void SupprimerAgence(Agence agence);
        void ModifierAgence(Agence agence);
    }
}
