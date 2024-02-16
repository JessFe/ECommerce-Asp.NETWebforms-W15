using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public static class GestCarrello
    {
        private static List<Articolo> carrello = new List<Articolo>();

        public static void AggiungiAlCarrello(Articolo articolo)
        {
            carrello.Add(articolo);
        }

        public static void RimuoviDalCarrello(int articoloId)
        {
            Articolo articoloDaRimuovere = carrello.FirstOrDefault(a => a.ID == articoloId);
            if (articoloDaRimuovere != null)
            {
                carrello.Remove(articoloDaRimuovere);
            }
        }

        public static void SvuotaCarrello()
        {
            carrello.Clear();
        }

        public static List<Articolo> GetArticoli()
        {
            return carrello;
        }

        public static decimal CalcolaTotale()
        {
            return carrello.Sum(a => a.Prezzo);
        }
    }
}