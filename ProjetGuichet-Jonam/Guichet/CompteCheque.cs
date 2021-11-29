using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{    
    class CompteCheque : CompteClient
    {
        public CompteCheque(string numerocompte, Client client,  int solde)
        {
            this.Numerocompte = numerocompte;
            this.Client = client;
            this.Solde = solde;
        }
    }
}
