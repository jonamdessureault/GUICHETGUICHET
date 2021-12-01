using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{    
    class CompteCheque : CompteClient
    {
        public CompteCheque(string numerocompte, int solde) : base(numerocompte, solde)
        {
            this.Numerocompte = numerocompte;
            this.Solde = solde;
        }
    }
}
