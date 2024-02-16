using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    // Gestisce le operazioni sul carrello come aggiungere, rimuovere articoli, e calcolare il totale.
    public static class GestCarrello
    {
        // Lista statica che rappresenta il carrello degli acquisti
        private static List<Articolo> carrello = new List<Articolo>();

        // Aggiunge un articolo al carrello
        public static void AggiungiAlCarrello(Articolo articolo)
        {
            carrello.Add(articolo);
        }

        // Rimuove un articolo dal carrello, basato sull'ID
        public static void RimuoviDalCarrello(int articoloId)
        {
            Articolo articoloDaRimuovere = carrello.FirstOrDefault(a => a.ID == articoloId);
            if (articoloDaRimuovere != null)
            {
                carrello.Remove(articoloDaRimuovere);
            }
        }

        // Svuota tutti gli articoli dal carrello
        public static void SvuotaCarrello()
        {
            carrello.Clear();
        }

        // Restituisce tutti gli articoli nel carrello
        public static List<Articolo> GetArticoli()
        {
            return carrello;
        }

        // Calcola il totale del prezzo di tutti gli articoli nel carrello
        public static decimal CalcolaTotale()
        {
            return carrello.Sum(a => a.Prezzo);
        }
    }
}