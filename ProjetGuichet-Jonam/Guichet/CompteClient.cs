using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    public abstract class CompteClient
    {
        private string numerocompte;
        private decimal soldeCompte;

        public string Numerocompte { get => numerocompte; set => numerocompte = value; }
        public decimal SoldeCompte { get => soldeCompte; set => soldeCompte = value; }
        public CompteClient(string numerocompte, decimal soldeCompte)
        {

        }


    }
}
