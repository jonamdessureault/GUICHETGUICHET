using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{    
    class CompteEpargne : CompteClient
    {
        public CompteEpargne(string numerocompte, Client client, int solde)
        {
            this.Numerocompte = numerocompte;
            this.Client = client;
            this.Solde = solde;
        }
    }
}
