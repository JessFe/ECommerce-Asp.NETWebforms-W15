namespace WebApplication1
{
    public class Articolo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string ImmaginePath { get; set; }

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