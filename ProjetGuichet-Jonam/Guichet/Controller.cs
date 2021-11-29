using System;
using System.Collections.Generic;

namespace Guichet
{
    class Controller
    {
        static void Main(string[] args)
        {
            
            Client Jonam = new Client("JonamDes", 1234);
            Client Firdaous = new Client("Firdaous", 4321);
            Client Paul = new Client("PaulFaye", 1122);
            Client Felipe = new Client("FelipeMo", 3344);
            Client Patrick = new Client("PatrickR", 0123);
            CompteEpargne compteEpargneJonam = new CompteEpargne("00000001", Jonam, 400);
            CompteCheque compteChequeJonam = new CompteCheque("00000001", Jonam, 401);
            CompteEpargne compteEpargneFirdaous = new CompteEpargne("00000002", Firdaous, 800);
            CompteCheque compteChequeFirdaous = new CompteCheque("00000002", Firdaous, 801);
            CompteEpargne compteEpargnePaul = new CompteEpargne("00000003", Paul, 600);
            CompteCheque compteChequePaul = new CompteCheque("00000003", Paul, 601);
            CompteEpargne compteEpargneFelipe = new CompteEpargne("00000004", Felipe, 700);
            CompteCheque compteChequeFelipe = new CompteCheque("00000004", Felipe, 701);
            CompteEpargne compteEpargnePatrick = new CompteEpargne("00000005", Patrick, 500);
            CompteCheque compteChequePatrick = new CompteCheque("00000005", Patrick, 501);
            List<CompteClient> Comptes = new List<CompteClient>();
            Comptes.Add(compteEpargneJonam);
            Comptes.Add(compteChequeJonam);
            Comptes.Add(compteEpargneFirdaous);
            Comptes.Add(compteChequeFirdaous);
            Comptes.Add(compteEpargnePaul);
            Comptes.Add(compteChequePaul);
            Comptes.Add(compteEpargneFelipe);
            Comptes.Add(compteChequeFelipe);
            Comptes.Add(compteEpargnePatrick);
            Comptes.Add(compteChequePatrick);

            Guichet guichet = new Guichet(Comptes);
            guichet.MenuPrincipal();
        }
    }
}
