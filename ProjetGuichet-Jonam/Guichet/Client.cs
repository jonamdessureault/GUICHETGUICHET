using System;
using System.Collections.Generic;
using System.Text;

namespace Guichet
{
    class Client
    {
        private string nomClient;
        private int nipClient;

        public Client(string nomClient, int nipClient)
        {
            this.nomClient = nomClient;
            this.nipClient = nipClient;
        }

        public string NomClient { get => nomClient; set => nomClient = value; }
        public int NipClient { get => nipClient; set => nipClient = value; }
    }
}
