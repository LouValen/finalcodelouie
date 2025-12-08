using System;

public static class Music
{
    public static void Run()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("                 ███████████                 ");
            Console.WriteLine("             ████           ████             ");
            Console.WriteLine("          ███                   ███          ");
            Console.WriteLine("         ██                       ██         ");
            Console.WriteLine("        ██      M  U  S  I  C      ██        ");
            Console.WriteLine("        ██                         ██        ");
            Console.WriteLine("         ██                       ██          ");
            Console.WriteLine("          ███                   ███          ");
            Console.WriteLine("             ████           ████             ");
            Console.WriteLine("                 ███████████                 ");

            Console.WriteLine("Choose Genre:");
            Console.WriteLine("[A] OPM");
            Console.WriteLine("[B] FOREIGN");
            Console.WriteLine("[C] KPOP");
            Console.Write("Enter A/B/C: ");

            string? genreInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(genreInput))
                continue;

            string genreChoice = genreInput.ToUpper();

            string genre = "";
            string[] artists = Array.Empty<string>();

            switch (genreChoice)
            {
                case "A":
                    genre = "OPM";
                    artists = new[] { "A: Arthur Nery", "B: Ben&Ben", "C: Moira" };
                    break;

                case "B":
                    genre = "FOREIGN";
                    artists = new[] { "A: Taylor Swift", "B: Eminem", "C: Bruno Mars" };
                    break;

                case "C":
                    genre = "KPOP";
                    artists = new[] { "A: BTS", "B: IU", "C: NewJeans" };
                    break;

                default:
                    Console.WriteLine("Invalid genre.");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine($"\nYou picked: {genre}");
            Console.WriteLine("\nChoose Artist:");

            foreach (var a in artists) Console.WriteLine(a);

            Console.Write("Enter A/B/C: ");
            string? artistInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(artistInput))
                continue;

            string artistPick = artistInput.ToUpper();

            string[]? songs = null;

            switch (genre)
            {
                case "OPM":
                    songs = artistPick switch
                    {
                        "A" => new[] { "1. Pagsamo", "2. Binhi", "3. Higa", "4. Life Puzzle", "5. LDR" },
                        "B" => new[] { "1. Kathang Isip", "2. Leaves", "3. Pagtingin", "4. Araw-Araw", "5. Maybe The Night" },
                        "C" => new[] { "1. Paubaya", "2. Tagpuan", "3. Malaya", "4. Ikaw at Ako", "5. Torete (Cover)" },
                        _ => null
                    };
                    break;

                case "FOREIGN":
                    songs = artistPick switch
                    {
                        "A" => new[] { "1. Love Story", "2. Enchanted", "3. Blank Space", "4. Lover", "5. Wildest Dreams" },
                        "B" => new[] { "1. Stan", "2. Lose Yourself", "3. Rap God", "4. Not Afraid", "5. Mockingbird" },
                        "C" => new[] { "1. Treasure", "2. Grenade", "3. When I Was Your Man", "4. Versace On The Floor", "5. 24K Magic" },
                        _ => null
                    };
                    break;

                case "KPOP":
                    songs = artistPick switch
                    {
                        "A" => new[] { "1. Spring Day", "2. Dynamite", "3. Butter", "4. Fake Love", "5. Boy With Luv" },
                        "B" => new[] { "1. Love Poem", "2. Palette", "3. Blueming", "4. Eight", "5. Celebrity" },
                        "C" => new[] { "1. OMG", "2. Ditto", "3. Hype Boy", "4. Attention", "5. Super Shy" },
                        _ => null
                    };
                    break;
            }

            if (songs == null)
            {
                Console.WriteLine("Invalid artist.");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine("\n--- SONG CHOICES ---");
            foreach (var s in songs) Console.WriteLine(s);

            Console.Write("\nPick a song (1-5): ");
            string? songPick = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(songPick))
                continue;

            Console.WriteLine("\n--- PERSONALITY PREDICTION ---");

            switch (songPick)
            {
                case "1": Console.WriteLine("You are a deep thinker, emotional, and value meaningful moments."); break;
                case "2": Console.WriteLine("You are romantic, soft-hearted, and sentimental."); break;
                case "3": Console.WriteLine("You are expressive, dramatic, and passionate."); break;
                case "4": Console.WriteLine("You are calm, understanding, and reflective."); break;
                case "5": Console.WriteLine("You are loyal, hopeful, and a dreamer type."); break;
                default:
                    Console.WriteLine("Invalid song choice.");
                    continue;
            }

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("[B] BACK to Genre Selection");
            Console.WriteLine("[E] EXIT");

            string? optionInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(optionInput))
                continue;

            string option = optionInput.ToUpper();

            if (option == "E")
                return;
        }
    }
}

