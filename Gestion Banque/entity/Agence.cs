using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.Implementation;



namespace GestionBanque.entity
{
    internal class Agence : IAgence
    {
        private int id;
        private string code;
        private string libelle;
        public client Client { get; set; } 
        private static int compteAgence;

        public Agence(int id, string code, string libelle, client client )
        {
            this.id = id;
            this.code = code;
            Client = client;
            this.libelle = GenerateLib( id, code);
        }
        public Agence()
        {
            compteAgence++;
            id = compteAgence;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Code
            { get { return code; } set {
                code = value; } }
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public override string ToString() {
            return "ID:" + Id + "Code:" + code + "Libelle" + libelle + "CLIENT:" + Client;
        }
        

        public static string GenerateLib(int id, string code)
        {
            
            string premiersLettres = (code.Length >= 3) ? code.Substring(0, 3) : code;

            
            string libelle = id + premiersLettres;

            return libelle;
        }
        List<Agence> agences = new List<Agence>();

        public void AjouterAgence(Agence agence)

        {
            agences.Add(agence);
        }
        public void SupprimerAgence(Agence agence)
        {
           agences.Remove(agence);
        }
        public void ModifierAgence(Agence agence)
        {
            //
        }


    }
}
