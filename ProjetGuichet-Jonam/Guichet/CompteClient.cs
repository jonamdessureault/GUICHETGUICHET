using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    public abstract class CompteClient
    {
        private string numerocompte;
        private Client client;
        private int solde;

        public string Numerocompte { get => numerocompte; set => numerocompte = value; }
        public int Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }

        public CompteClient()
        {

        }
    }
}
