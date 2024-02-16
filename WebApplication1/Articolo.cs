namespace WebApplication1
{
    // Definisce la classe Articolo con proprietà per ID, Nome, Descrizione, Prezzo e il percorso dell'immagine.
    // Questa classe rappresenta un singolo articolo nell ecommerce.

    public class Articolo
    {
        // Proprietà per accedere alle informazioni dell'articolo
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string ImmaginePath { get; set; }

        // Costruttore per creare un'istanza di Articolo
        public Articolo(int id, string nome, string descrizione, decimal prezzo, string immaginePath)
        {
            ID = id;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            ImmaginePath = immaginePath;
        }
    }
}