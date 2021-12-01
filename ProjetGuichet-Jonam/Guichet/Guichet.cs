using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    public class Guichet
    {
        private List<Client> listeClients;
        private int soldeGuichet;
        private string adminLogin;
        private string adminPassword;

        // Le constructeur ci-dessous contient des valeurs par défaut, cela nous évite de réécrire les valeurs dans le Guichet guichet = new Guichet(Clients)
        public Guichet(List<Client> listeClients, int soldeGuichet = 10000, string adminLogin = "admin", string adminPassword = "123456")
        {
            this.listeClients = listeClients;
            this.soldeGuichet = soldeGuichet;
            this.adminLogin = adminLogin;
            this.adminPassword = adminPassword;

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
        public void ChoixMenuPrincipal(string choix)
        {
            switch (choix)
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

        public void SeConnecterClient()
        {
            int compteurClient = 0;
            int compteur = 0;
            Console.WriteLine("Veuillez entrer vos identifiants: ");
            Console.WriteLine("Nom: ");
            string nomClient = Console.ReadLine();
            Console.WriteLine("Mot de passe: ");
            string motDePasseClient = Console.ReadLine();


            foreach (Client compteClient in listeClients)
            {
                if (nomClient == compteClient.NomClient)
                {
                    compteurClient++;
                    if (motDePasseClient == compteClient.NipClient)
                    {
                        MenuPersonnel();
                    }
                    else
                    {
                        Console.WriteLine("Votre mot de passe ou votre login est incorrect");
                        compteur++;
                    }
                    break;

                    if (compteur == 3)
                    {
                        Console.WriteLine("Votre compte est désormais verrouillé.");
                    }

                }
            }
            if (compteurClient == 0)
            {
                Console.WriteLine("Votre mot de passe ou votre login est incorrect");
                compteur++;
            }

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

        public void ChoixMenuPersonnel(string choix)
        {
            switch (choix)
            {
                case "1":
                    ChangerMotDePasse();
                    break;

                    case
            }
        }

        public void SeConnecterAdmin()
        {
            int compteur = 0;
            string nomAdmin;
            string motDePasseAdmin;
            do
            {
                Console.WriteLine("Veuillez entrer vos identifiants: ");
                Console.WriteLine("Nom: ");
                nomAdmin = Console.ReadLine();
                Console.WriteLine("Mot de passe: ");
                motDePasseAdmin = Console.ReadLine();

                if ((nomAdmin == adminLogin) & (motDePasseAdmin == adminPassword))
                {
                    MenuAdmin();
                }
                else
                {
                    Console.WriteLine("Votre mot de passe ou votre login est incorrect.");
                    compteur++;
                }
            } while ((compteur != 3) & ((nomAdmin != adminLogin) & (motDePasseAdmin != adminPassword)));

            if (compteur == 3)
            {
                Console.WriteLine("TROP DE TENTATIVES, SYSTÈME EN PANNE");
            }
            if(compteur == 0)
            {
                Console.WriteLine("Votre mot de passe ou votre login est incorrect.");
            }
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
    }
}
