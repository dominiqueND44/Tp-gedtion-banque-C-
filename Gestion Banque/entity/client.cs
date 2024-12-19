using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;
using LanguageExt.Pipes;
using GestionBanque.Implementation;
using System.Numerics;

namespace GestionBanque.entity
{
    internal class client:IClient
    {
        private int idclient;
        private string prenom;
        private string nom;
        private long tel;
        public Compte Compte { get; set; }
        private static int clientnb;

        public client(int id, string prenom, string nom, long tel, Compte compte)
        {
            this.idclient = id;
            this.prenom = prenom;
            this.nom = nom;
            this.tel = tel;
            Compte = compte;
        }
        public client()
        {
            clientnb++;
            idclient = clientnb;
            
        }

        public int Idclient { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public long Tel { get; set; }

        public override string ToString()
        {
            return "ID:" + idclient + "prenom : " + prenom + " nom: " + nom + "telephone: " + tel + "COMPTE:" + Compte;
        }

        List<client> clients = new List<client>();


        public void AjouterClient(client client)
        {
            clients.Add(client);

        }
        public void SupprimerClient(client client)
        {
            clients.Remove(client);
        }
        public void ModifierClient(client client)
        {
            //
        }
       




    }
}
