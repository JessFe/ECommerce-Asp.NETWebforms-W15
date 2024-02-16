using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public static class Articoli
    {
        private static List<Articolo> articoli = new List<Articolo>
        {
            new Articolo(1, "Articolo 1", "Descrizione dell'articolo 1", 100m, "path/to/image1.jpg"),
            new Articolo(2, "Articolo 2", "Descrizione dell'articolo 2", 150m, "path/to/image2.jpg"),
            // Aggiungi qui nuovi articoli in futuro
        };

        public static List<Articolo> GetArticoli()
        {
            return articoli;
        }

        public static Articolo GetArticoloById(int id)
        {
            return articoli.FirstOrDefault(a => a.ID == id);
        }

        // Metodo per aggiungere nuovi articoli, se necessario
        public static void AggiungiArticolo(Articolo articolo)
        {
            articoli.Add(articolo);
        }
    }
}
