using System;
using System.Threading;

public static class ZodiacIDCard
{
    static void TypeText(string text, int delay = 30)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
    }

    static void PrintCard(string zodiac, string symbol, string dates, string element, 
                         string trait1, string trait2, string trait3, string description)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                   ★ ZODIAC IDENTITY CARD ★                       ║");
        Console.WriteLine("╠═══════════════════════════════════════════════════════════════════╣");
        Console.ResetColor();
        
        // Symbol
        string[] symbolLines = symbol.Split('\n');
        foreach (string line in symbolLines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("║" + line.PadRight(67) + "║");
            }
        }
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╠═══════════════════════════════════════════════════════════════════╣");
        Console.ResetColor();
        
        // Info section
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("║                                                                   ║");
        Console.Write("║  ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("SIGN: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeText(zodiac.ToUpper(), 50);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(new string(' ', 67 - zodiac.Length - 8) + "║");
        
        Console.Write("║  ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("DATES: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(dates);
        Console.WriteLine(new string(' ', 67 - dates.Length - 9) + "║");
        
        Console.Write("║  ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("ELEMENT: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(element);
        Console.WriteLine(new string(' ', 67 - element.Length - 11) + "║");
        
        Console.WriteLine("║                                                                   ║");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  ─────────────────────────────────────────────────────────────  ║");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("║  KEY TRAITS:                                                      ║");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"║    ► {trait1.PadRight(58)}║");
        Console.WriteLine($"║    ► {trait2.PadRight(58)}║");
        Console.WriteLine($"║    ► {trait3.PadRight(58)}║");
        Console.WriteLine("║                                                                   ║");
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║  ─────────────────────────────────────────────────────────────  ║");
        Console.ForegroundColor = ConsoleColor.White;
        
        // Wrap description text
        string[] words = description.Split(' ');
        string currentLine = "║  ";
        foreach (string word in words)
        {
            if ((currentLine + word).Length > 65)
            {
                Console.WriteLine(currentLine.PadRight(68) + "║");
                currentLine = "║  " + word + " ";
            }
            else
            {
                currentLine += word + " ";
            }
        }
        if (currentLine.Length > 3)
        {
            Console.WriteLine(currentLine.PadRight(68) + "║");
        }
        
        Console.WriteLine("║                                                                   ║");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
    }

    public static void Run()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        TypeText("═══════════════════════════════════════════════\n", 10);
        TypeText("   ★ WELCOME TO ZODIAC ID CARD GENERATOR ★\n", 20);
        TypeText("═══════════════════════════════════════════════\n\n", 10);
        Console.ResetColor();
        
        Thread.Sleep(500);
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter your zodiac sign: ");
        Console.ForegroundColor = ConsoleColor.White;
        string zodiac = (Console.ReadLine() ?? "").Trim().ToLower();

        Console.Clear();
        Thread.Sleep(300);
        
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText("⚡ GENERATING ID CARD", 50);
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(300);
            Console.Write(".");
        }
        Console.WriteLine("\n");
        Console.ResetColor();
        Thread.Sleep(500);

        switch (zodiac)
        {
            case "aries":
                PrintCard("Aries", @"
           ████         ████
          ██████       ██████
         ███  ███     ███  ███
              ███     ███
               ███   ███
                ███ ███
                 █████
                  ███", "March 21 - April 19", "Fire", 
                    "Courageous", "Confident", "Passionate",
                    "Energetic and assertive natural leaders. Aries are bold pioneers who fearlessly charge forward with determination and enthusiasm.");
                break;

            case "taurus":
                PrintCard("Taurus", @"
             ███████████
            ███       ███
               █████
            ███████████
           ███         ███
          ███           ███
           ███         ███
            ███████████", "April 20 - May 20", "Earth",
                    "Reliable", "Patient", "Devoted",
                    "Grounded and practical with a love for stability. Taurus values loyalty, comfort, and the finer things in life.");
                break;

            case "gemini":
                PrintCard("Gemini", @"
         ███             ███
          ███████████████
          ███           ███
          ███           ███
          ███           ███
          ███████████████
         ███             ███", "May 21 - June 20", "Air",
                    "Adaptable", "Curious", "Communicative",
                    "Versatile and intellectually curious social butterflies. Gemini thrives on variety, conversation, and mental stimulation.");
                break;

            case "cancer":
                PrintCard("Cancer", @"
              ███████████
            ███         ██
           ██     ███████
          ██   ████   ████
          ██   ████   ███
           ██   ████████
            ███     ███
              ███████", "June 21 - July 22", "Water",
                    "Nurturing", "Intuitive", "Protective",
                    "Deeply emotional and caring souls who value family and home. Cancer feels everything intensely and protects their loved ones fiercely.");
                break;

            case "leo":
                PrintCard("Leo", @"
              ███████████
            ███         ███
           ██             ██
           ██             ██
          ███████████████
           ██           ██
           ███         ███
            ████     ████", "July 23 - August 22", "Fire",
                    "Charismatic", "Generous", "Creative",
                    "Confident and theatrical natural-born leaders. Leo loves the spotlight, creativity, and inspiring others with their warmth and enthusiasm.");
                break;

            case "virgo":
                PrintCard("Virgo", @"
          ███         ███
           ███       ███ ████
            ███     ███  ████
             ███   ███    ██
              ███ ███     ██
               ██████     ██
                ████
               ██████", "August 23 - September 22", "Earth",
                    "Analytical", "Practical", "Meticulous",
                    "Detail-oriented perfectionists with excellent problem-solving skills. Virgo excels at organization, analysis, and helping others improve.");
                break;

            case "libra":
                PrintCard("Libra", @"
              ██████████
             ███      ███
             ██        ██
         ████████    ████████
         ████████    ████████

         ██████████████████", "September 23 - October 22", "Air",
                    "Diplomatic", "Fair-minded", "Social",
                    "Graceful and charming seekers of balance and harmony. Libra values beauty, relationships, and creating peace wherever they go.");
                break;

            case "scorpio":
                PrintCard("Scorpio", @"
          ███        ███
           ███      ███ ████
            ███    ███  ████
             ███  ███    ██
              ██████     ██
               ████      ██
                 ███████
                       ██", "October 23 - November 21", "Water",
                    "Intense", "Passionate", "Mysterious",
                    "Powerful and transformative with incredible depth. Scorpio feels everything profoundly and possesses remarkable strength and resourcefulness.");
                break;

            case "sagittarius":
                PrintCard("Sagittarius", @"
                 ███████████
                       ████
                     ████
         ████      ████
          █████  ████
            ████████
             ██████
            ████████
           ████  ████
          ████    ████", "November 22 - December 21", "Fire",
                    "Adventurous", "Optimistic", "Philosophical",
                    "Freedom-loving explorers with boundless enthusiasm. Sagittarius thrives on adventure, learning, and expanding horizons through travel and ideas.");
                break;

            case "capricorn":
                PrintCard("Capricorn", @"
           ████████    ██████
          ████  ███   ████ ███
                ███  ███   ███
                ███ ███    ███
                ██████     ███
                █████      ███
                █████  ████████
                            ███
                          ████
                       ████", "December 22 - January 19", "Earth",
                    "Ambitious", "Disciplined", "Responsible",
                    "Determined and practical achievers who value tradition. Capricorn works steadily toward long-term goals with patience and perseverance.");
                break;

            case "aquarius":
                PrintCard("Aquarius", @"
            ███     ███    ███
          ██████ ██████ ██████
         ███  ███████████  ████
         ███   █████████   ███

           ███    ███    ███
         ██████ ██████ ██████
        ███  ███████████  ████
        ███   █████████   ███", "January 20 - February 18", "Air",
                    "Innovative", "Independent", "Humanitarian",
                    "Visionary thinkers who march to their own drum. Aquarius values originality, progress, and making the world a better place for all.");
                break;

            case "pisces":
                PrintCard("Pisces", @"
             ████          ████
              ████        ████
               ████      ████
                ████    ████
          ██████████████████████
                ████    ████
               ████      ████
              ████        ████
             ████          ████", "February 19 - March 20", "Water",
                    "Compassionate", "Artistic", "Intuitive",
                    "Dreamy and empathetic souls deeply connected to emotion. Pisces possesses powerful imagination and understands the mystical side of life.");
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                          ⚠ ERROR ⚠                               ║");
                Console.WriteLine("║                                                                   ║");
                Console.WriteLine("║  Unknown zodiac sign. Please try again with a valid sign:         ║");
                Console.WriteLine("║  (Aries, Taurus, Gemini, Cancer, Leo, Virgo, Libra, Scorpio,     ║");
                Console.WriteLine("║   Sagittarius, Capricorn, Aquarius, Pisces)                       ║");
                Console.WriteLine("║                                                                   ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();
                break;
        }

        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Press any key to return to main menu...");
        Console.ResetColor();
        Console.ReadLine();
    }
}
