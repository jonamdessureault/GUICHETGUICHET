using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    public class Client
    {
        private string nomClient;
        private string nipClient;
        private bool actif;
        private CompteClient compteEpargne;
        private CompteClient compteCheque;


        public Client(string nomClient, string nipClient,CompteClient compteEpargne, CompteClient compteCheque)
        {
            this.nomClient = nomClient;
            this.nipClient = nipClient;
            this.actif = true;
            this.compteEpargne = compteEpargne;
            this.compteCheque = compteCheque;
        }

        public string NomClient { get => nomClient; set => nomClient = value; }
        public string NipClient { get => nipClient; set => nipClient = value; }

        public void VerrouillerCompte()
        {
            this.actif = false;
        }

        public void DeverrouillerCompte()
        {
            this.actif = true;
        }

        public bool IsCompteVerrouille()
        {
            return this.actif;
        }
        //public bool Actif { get => actif; set => actif = value; }
    }
}
