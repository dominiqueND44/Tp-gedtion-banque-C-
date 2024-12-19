using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.entity;

namespace GestionBanque.Implementation
{
    internal interface IClient
    {
        void AjouterClient(client client );
       
        void SupprimerClient(client client);
        void ModifierClient(client client);
    }
}
