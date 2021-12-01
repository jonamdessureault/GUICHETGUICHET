using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    public abstract class CompteClient
    {
        private string numerocompte;
        private int solde;

        public string Numerocompte { get => numerocompte; set => numerocompte = value; }
        public int Solde { get => solde; set => solde = value; }
        public CompteClient(string numerocompte, int solde)
        {

        }
    }
}
