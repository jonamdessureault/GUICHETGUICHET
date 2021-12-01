using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{    
    class CompteEpargne : CompteClient
    {
        public CompteEpargne(string numerocompte, int solde):base(numerocompte, solde)
        {
            this.Numerocompte = numerocompte;
            this.Solde = solde;
        }
    }
}
