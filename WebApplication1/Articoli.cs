using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    // Agisce come un repository statico per gli articoli, simulando un database.
    public static class Articoli
    {
        // Lista statica che simula un database di articoli
        private static List<Articolo> articoli = new List<Articolo>
        {
            new Articolo(1, "Commodore PET",
                "The Commodore PET is a line of personal computers produced starting in 1977 by Commodore International. A single all-in-one case combines a MOS Technology 6502 microprocessor, Commodore BASIC in read-only memory, keyboard, monochrome monitor, and, in early models, a cassette deck.",
                795m, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Commodore_2001_Series-IMG_0448b.jpg/1280px-Commodore_2001_Series-IMG_0448b.jpg"),
            new Articolo(2, "Commodore 64",
                "The Commodore 64 is a classic 8-bit home computer that was introduced by Commodore International in 1982. It quickly became one of the best-selling and most iconic personal computers of its time.",
                595m, "https://hips.hearstapps.com/hmg-prod/images/commodore-64-compie-40-anni-1661036401.png"),
            new Articolo(3, "Apple II Plus",
                "The Apple II Plus is the second model of the Apple II series of personal computers produced by Apple Computer. It was sold from June 1979 to December 1982.",
                1195m, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Apple_II_Plus.jpg/1920px-Apple_II_Plus.jpg"),
            new Articolo(4, "Atari Home Pong",
                "An early home version of Pong, Atari's Home Pong console allowed players to experience the popular arcade game in their living rooms. It marked one of the first commercially successful home gaming experiences.",
                99m, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/TeleGames-Atari-Pong.jpg/1200px-TeleGames-Atari-Pong.jpg"),
            new Articolo(5, "IBM PC",
                "The IBM Personal Computer is a landmark in the history of personal computing, introduced by IBM in August 1981. It is often regarded as the first successful mass-produced personal computer.",
                1565m, "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/IBM_PC-IMG_7271_%28transparent%29.png/1920px-IBM_PC-IMG_7271_%28transparent%29.png"),
            new Articolo(6, "Atari 400",
                "Atari, known for its success in the gaming industry, ventured into home computers with the Atari 400 and 800. These machines featured custom graphics and sound chips, making them popular for both gaming and educational purposes.",
                550m, "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Atari-400-Comp.jpg/1199px-Atari-400-Comp.jpg"),
            new Articolo(7, "Atari 800",
                "Atari, known for its success in the gaming industry, ventured into home computers with the Atari 400 and 800. These machines featured custom graphics and sound chips, making them popular for both gaming and educational purposes.",
                1000m, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Atari-800-Computer-FL-No-Cover-Expansions.jpg/1200px-Atari-800-Computer-FL-No-Cover-Expansions.jpg"),
            new Articolo(8, "Macintosh 128K",
                "The Macintosh 128K, often referred to as the \"Macintosh 128,\" was the first commercially successful personal computer to feature a graphical user interface and a mouse. Released by Apple in 1984, it played a pivotal role in the evolution of personal computing.",
                2498m, "https://designindex.it/foto/289/mac_128k_01-grande.jpg"),
            new Articolo(9, "Intellivision",
                "The Intellivision is a home video game console released by Mattel Electronics in 1979. The name is a portmanteau of \"intelligent television\". Development began in 1977, the same year as the launch of its main competitor, the Atari 2600.",
                275m, "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Intellivision-Console-Set.png/1920px-Intellivision-Console-Set.png"),
            new Articolo(10, "Game & Watch",
                "The Game & Watch brand is a series of handheld electronic games developed, manufactured, released, and marketed by Nintendo from 1980 to 1991.",
                0m, "https://upload.wikimedia.org/wikipedia/commons/1/15/Game_%26_Watch.png"),
            new Articolo(11, "Amiga 500",
                "The Amiga 500 was the first popular version of the Amiga home computer, \"redefining the home computer market and making so-called luxury features such as multitasking and colour a standard long before Microsoft or Apple sold these to the masses\".",
                699m, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Amiga500_system.jpg/1920px-Amiga500_system.jpg"),
            new Articolo(12, "Nintendo Entertainment System",
                "The NES, released by Nintendo, is a landmark console that revitalized the video game industry after the North American video game crash of 1983. It introduced iconic franchises like Super Mario Bros. and The Legend of Zelda.",
                179m, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b2/NES-Console-Set.png/1920px-NES-Console-Set.png"),
            new Articolo(13, "Atari 2600",
                "The Atari 2600 is a pioneering home video game console released by Atari, Inc. in 1977. It played a crucial role in popularizing home gaming and is often credited with helping to establish the video game industry.",
                199m, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Atari-2600-Wood-4Sw-Set.jpg/1200px-Atari-2600-Wood-4Sw-Set.jpg"),
            new Articolo(14, "Atari 5200",
                "The Atari 5200 is a video game console released by Atari, Inc. in 1982 as the successor to the popular Atari 2600. It was designed to offer more advanced hardware capabilities and improved graphics compared to its predecessor.",
                299m, "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Atari-5200-4-Port-wController-L.jpg/1199px-Atari-5200-4-Port-wController-L.jpg"),
            new Articolo(15, "Master System",
                "The Master System is an 8-bit third-generation home video game console manufactured and developed by Sega. It was originally a remodeled export version of the Sega Mark III, the third iteration of the SG-1000.",
                530m, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Sega-Master-System-Set.jpg/1920px-Sega-Master-System-Set.jpg"),
            new Articolo(16, "Game Boy",
                "The Game Boy is an 8-bit fourth generation handheld game console developed and manufactured by Nintendo. It was first released in Japan on April 21, 1989, in North America later the same year, and in Europe in late 1990.",
                90m, "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Game-Boy-FL.jpg/1024px-Game-Boy-FL.jpg")
            // Aggiungi qui nuovi articoli in futuro
        };

        // Metodi per accedere agli articoli

        // restituisce l'intera lista di 'Articolo'
        public static List<Articolo> GetArticoli()
        {
            return articoli;
        }

        // cerca nella lista articoli per trovare un Articolo che abbia un ID corrispondente a quello passato come parametro
        public static Articolo GetArticoloById(int id)
        {
            return articoli.FirstOrDefault(a => a.ID == id);
        }


    }
}
