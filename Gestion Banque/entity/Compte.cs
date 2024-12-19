using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt.Pipes;
using GestionBanque.Implementation;


namespace GestionBanque.entity
{
    internal abstract class Compte : ICompte
    {
        protected int id;
        protected string numeroCompte;
        protected int solde;
        public client Client { get; set; }
        protected static int nbcompte;

        protected Compte()
        {
        }

        protected Compte(int id, client client, int solde) 
        {
            this.id = id;
            this.numeroCompte = GenerateNumeroCompte(client); 
            this.solde = solde;
        }

        protected Compte(int id, string numeroCompte, int solde)
        {
            this.id = id;
            this.numeroCompte = numeroCompte;
            this.solde = solde;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NumeroCompte
        {
            get { return numeroCompte; }
            set { numeroCompte = value; }
        }
        public int Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public override string ToString()
        {
            return "ID:" +Id + "NUMERO DE COMPTE:" + NumeroCompte + "Solde" + Solde+ "CLIENT:" +Client;
        }

        public string GenerateNumeroCompte(client client)
        {
            return $"000{client.Idclient}{client.Tel}";
        }

        List<Compte> comptes = new List<Compte>();


        public void AjouterCompte(Compte compte)
        {
            comptes.Add(compte);
        }



        public void ConsulterCompte(Compte compte)
        {
            Console.WriteLine(compte.ToString());
        }

        public void SupprimerCompte(Compte compte)
        {
            comptes.Remove(compte);

        }
        public void ModifierCompte(Compte compte, int id)
        {
            //comptes.update(compte);
        }
    }
}
