using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.entity;
using GestionBanque.Implementation;

namespace GestionBanque
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Agence> agences = new List<Agence>();
            List<client> clients = new List<client>();
            List<Compte> comptes = new List<Compte>();
            int choix;

            do
            {
                Console.WriteLine("\n--- Menu Gestion Institution ---");
                Console.WriteLine("1. CRUD AGENCE");
                Console.WriteLine("2. CRUD CLIENT");
                Console.WriteLine("3. CRUD COMPTE");
                Console.WriteLine("4. Quitter");
                Console.Write("Choisissez une option : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        MenuAgence(agences);
                        break;
                    case 2:
                        MenuClient(clients);
                        break;
                    case 3:
                        MenuCompte(comptes, clients); // Passer la liste des clients pour la création de comptes
                        break;
                    case 4:
                        Console.WriteLine("Au revoir !");
                        break;
                    default:
                        Console.WriteLine("Option invalide, veuillez réessayer.");
                        break;
                }
            } while (choix != 4);
        }

        private static void MenuAgence(List<Agence> agences)
        {
            int choix;
            do
            {
                Console.WriteLine("\n--- CRUD AGENCE ---");
                Console.WriteLine("1. Ajouter Agence");
                Console.WriteLine("2. Afficher Agences");
                Console.WriteLine("3. Supprimer Agence");
                Console.WriteLine("4. Modifier Agence");
                Console.WriteLine("5. Quitter");
                Console.Write("Choisissez une option : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        
                        Console.Write("Code : ");
                        string code = Console.ReadLine();
                        Console.Write("Libelle : ");
                        string libelle = Console.ReadLine();
                        agences.Add(new Agence(0, code, libelle, null)); 
                        Console.WriteLine("Agence ajoutée.");
                        break;
                    case 2:
                        
                        Console.WriteLine("Liste des agences :");
                        foreach (var agence in agences)
                        {
                            Console.WriteLine(agence);
                        }
                        break;
                    case 3:
                        
                        Console.Write("ID de l'agence à supprimer : ");
                        int id = int.Parse(Console.ReadLine());
                        var agenceASupprimer = agences.Find(a => a.Id == id);
                        if (agenceASupprimer != null)
                        {
                            agences.Remove(agenceASupprimer);
                            Console.WriteLine("Agence supprimée.");
                        }
                        else
                        {
                            Console.WriteLine("Agence non trouvée.");
                        }
                        break;
                    case 4:
                        
                        Console.Write("ID de l'agence à modifier : ");
                        int idModif = int.Parse(Console.ReadLine());
                        var agenceAModifier = agences.Find(a => a.Id == idModif);
                        if (agenceAModifier != null)
                        {
                            Console.Write("Nouveau code : ");
                            agenceAModifier.Code = Console.ReadLine();
                            Console.Write("Nouveau libelle : ");
                            agenceAModifier.Libelle = Console.ReadLine();
                            Console.WriteLine("Agence modifiée.");
                        }
                        else
                        {
                            Console.WriteLine("Agence non trouvée.");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }
            } while (choix != 5);
        }

        private static void MenuClient(List<client> clients)
        {
            int choix;
            do
            {
                Console.WriteLine("\n--- CRUD CLIENT ---");
                Console.WriteLine("1. Ajouter Client");
                Console.WriteLine("2. Afficher Clients");
                Console.WriteLine("3. Supprimer Client");
                Console.WriteLine("4. Modifier Client");
                Console.WriteLine("5. Quitter");
                Console.Write("Choisissez une option : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                       
                        Console.Write("Prénom : ");
                        string prenom = Console.ReadLine();
                        Console.Write("Nom : ");
                        string nom = Console.ReadLine();
                        Console.Write("Téléphone : ");
                        long tel = long.Parse(Console.ReadLine());
                        clients.Add(new client(0, prenom, nom, tel, null)); 
                        Console.WriteLine("Client ajouté.");
                        break;
                    case 2:
                        
                        Console.WriteLine("Liste des clients :");
                        foreach (var client in clients)
                        {
                            Console.WriteLine(client);
                        }
                        break;
                    case 3:
                        
                        Console.Write("ID du client à supprimer : ");
                        int idClient = int.Parse(Console.ReadLine());
                        var clientASupprimer = clients.Find(c => c.Idclient == idClient);
                        if (clientASupprimer != null)
                        {
                            clients.Remove(clientASupprimer);
                            Console.WriteLine("Client supprimé.");
                        }
                        else
                        {
                            Console.WriteLine("Client non trouvé.");
                        }
                        break;
                    case 4:
                        
                        Console.Write("ID du client à modifier : ");
                        int idClientModif = int.Parse(Console.ReadLine());
                        var clientAModifier = clients.Find(c => c.Idclient == idClientModif);
                        if (clientAModifier != null)
                        {
                            Console.Write("Nouveau prénom : ");
                            clientAModifier.Prenom = Console.ReadLine();
                            Console.Write("Nouveau nom : ");
                            clientAModifier.Nom = Console.ReadLine();
                            Console.Write("Nouveau téléphone : ");
                            clientAModifier.Tel = long.Parse(Console.ReadLine());
                            Console.WriteLine("Client modifié.");
                        }
                        else
                        {
                            Console.WriteLine("Client non trouvé.");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }
            } while (choix != 5);
        }

        private static void MenuCompte(List<Compte> comptes, List<client> clients)
        {
            int choix;
            do
            {
                Console.WriteLine("\n--- CRUD COMPTE ---");
                Console.WriteLine("1. Ajouter Compte");
                Console.WriteLine("2. Afficher Comptes");
                Console.WriteLine("3. Supprimer Compte");
                Console.WriteLine("4. Modifier Compte");
                Console.WriteLine("5. Quitter");
                Console.Write("Choisissez une option : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                       
                        Console.WriteLine("Sélectionnez un client par ID :");
                        foreach (var client in clients)
                        {
                            Console.WriteLine(client);
                        }
                        Console.Write("ID du client : ");
                        int idClient = int.Parse(Console.ReadLine());
                        var clientSelectionne = clients.Find(c => c.Idclient == idClient);

                        if (clientSelectionne != null)
                        {
                            Console.Write("Type de compte (1: Epargne, 2: Simple) : ");
                            int type = int.Parse(Console.ReadLine());
                            Console.Write("Solde initial : ");
                            int solde = int.Parse(Console.ReadLine());
                            Compte compte;
                            if (type == 1)
                            {
                                Console.Write("Durée : ");
                                int duree = int.Parse(Console.ReadLine());
                                compte = new compteEpargne(duree, 0, null, solde)
                                {
                                    Client = clientSelectionne
                                };
                            }
                            else
                            {
                                Console.Write("Taux de découvert : ");
                                int taux = int.Parse(Console.ReadLine());
                                compte = new compteSimple(taux, 0, null, solde)
                                {
                                    Client = clientSelectionne
                                };
                            }
                            comptes.Add(compte);
                            Console.WriteLine("Compte ajouté.");
                        }
                        else
                        {
                            Console.WriteLine("Client non trouvé.");
                        }
                        break;
                    case 2:
                        
                        Console.WriteLine("Liste des comptes :");
                        foreach (var c in comptes)
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    case 3:
                        
                        Console.Write("ID du compte à supprimer : ");
                        int idCompte = int.Parse(Console.ReadLine());
                        var compteASupprimer = comptes.Find(c => c.Id == idCompte);
                        if (compteASupprimer != null)
                        {
                            comptes.Remove(compteASupprimer);
                            Console.WriteLine("Compte supprimé.");
                        }
                        else
                        {
                            Console.WriteLine("Compte non trouvé.");
                        }
                        break;
                    case 4:
                        
                        Console.Write("ID du compte à modifier : ");
                        int idCompteModif = int.Parse(Console.ReadLine());
                        var compteAModifier = comptes.Find(c => c.Id == idCompteModif);
                        if (compteAModifier != null)
                        {
                            Console.Write("Nouveau solde : ");
                            compteAModifier.Solde = int.Parse(Console.ReadLine());
                            Console.WriteLine("Compte modifié.");
                        }
                        else
                        {
                            Console.WriteLine("Compte non trouvé.");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }
            } while (choix != 5);
        }
    }
}
