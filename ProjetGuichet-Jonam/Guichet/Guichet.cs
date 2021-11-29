using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    public class Guichet
    {
        private List<CompteClient> listeComptes;

        public Guichet(List<CompteClient> listeComptes)
        {
            this.listeComptes = listeComptes;
        }

        public void MenuPrincipal()
        {
            Console.WriteLine("Veuillez choisir l'une des options suivantes: ");
            Console.WriteLine("1- Se connecter à votre compte");
            Console.WriteLine("2- Se connecter comme administrateur");
            Console.WriteLine("3- Quitter");
            string ChoixPrincipal = Console.ReadLine();
            ChoixMenuPrincipal(ChoixPrincipal);
        }

        public void SeConnecterClient()
        {
            int compteurClient = 0;
            int compteur = 0;
            Console.WriteLine("Veuillez entrer vos identifiants: ");
            Console.WriteLine("Nom: ");
            string NomClient = Console.ReadLine();
            Console.WriteLine("Mot de passe: ");
            int MotDePasseClient = Convert.ToInt32(Console.ReadLine());

            foreach (CompteClient compteClient in listeComptes)
            {
                if (NomClient == compteClient.Client.NomClient)
                {
                    compteurClient++;
                    if (MotDePasseClient == compteClient.Client.NipClient)
                    {
                        MenuPersonnel(); 
                    }
                    else
                    {
                        Console.WriteLine("Identifiants incorrect, veuillez réessayer");
                        compteur++;
                    } 
                break;
                    if(compteur == 3)
                    {
                        Console.WriteLine("systeme bloqué");
                    }

                }
            }
            if(compteurClient==0)
            {
                Console.WriteLine("Identifiants incorrect, veuillez réessayer");
                compteur++;
            }
            
        }

        public void SeConnecterAdmin()
        {
            Console.WriteLine("Veuillez entrer vos identifiants: ");
            Console.WriteLine("Nom: ");
            string NomAdmin = Console.ReadLine();
            Console.WriteLine("Mot de passe: ");
            string MotDePasseAdmin = Console.ReadLine();
        }

        public void MenuPersonnel()
        {
            Console.WriteLine("Veuillez choisir l'une des options suivantes: ");
            Console.WriteLine("1- Changer de mot de passe");
            Console.WriteLine("2- Déposer un montant dans un compte");
            Console.WriteLine("3- Retirer un montant dans un compte");
            Console.WriteLine("4- Afficher le solde d'un compte");
            Console.WriteLine("5- Effectuer un virement entre les comptes");
            Console.WriteLine("6- Payer une facture");
            Console.WriteLine("7- Fermer la session");
            string ChoixMenuPerso = Console.ReadLine();
        }

        public void MenuAdmin()
        {
            Console.WriteLine("Veuillez choisir l'une des options suivantes: ");
            Console.WriteLine("1- Remettre le guichet en fonction");
            Console.WriteLine("2- Déposer de l'argent dans le guichet");
            Console.WriteLine("3- Afficher la liste des comptes");
            Console.WriteLine("4- Retourner au menu principal");
            string ChoixMenuAdmin = Console.ReadLine();
        }

        public void ChoixMenuPrincipal(string choix)
        {
            switch(choix)
            {
                case "1":
                    SeConnecterClient();
                    break;

                case "2":
                    SeConnecterAdmin();
                    break;
                case "3":
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}
