using System;
using System.Threading;

class ZodiacGame
{
    // ==============================
    // LOADING ANIMATION
    // ==============================
    static void Loading(string text)
    {
        Console.Clear();
        Console.Write(text);
        for (int i = 0; i < 6; i++)
        {
            Thread.Sleep(300);
            Console.Write(".");
        }
        Console.Clear();
    }

    // ==============================
    // CARD UI HELPERS
    // ==============================
    static void CardTop(int w)
    {
        Console.WriteLine("╔" + new string('═', w - 2) + "╗");
    }

    static void CardBottom(int w)
    {
        Console.WriteLine("╚" + new string('═', w - 2) + "╝");
    }

    static void Divider(int w)
    {
        Console.WriteLine("╠" + new string('═', w - 2) + "╣");
    }

    static void Line(int w)
    {
        Console.WriteLine("║".PadRight(w - 1) + "║");
    }

    static void Text(string txt, int w)
    {
        if (txt.Length > w - 4)
            txt = txt.Substring(0, w - 4);

        Console.WriteLine("║  " + txt.PadRight(w - 4) + "║");
    }

    // ==============================
    // ZODIAC CARD DISPLAY
    // ==============================
    static void ShowCard(string name, string element, string description, string[] symbol)
    {
        int width = 75;
        CardTop(width);
        Text("ZODIAC IDENTIFICATION CARD", width);
        Divider(width);
        
        // Symbol Box
        foreach (string line in symbol)
            Text(line, width);

        Line(width);

        Text("NAME: " + name, width);
        Text("ELEMENT: " + element, width);

        Line(width);

        Text("DESCRIPTION:", width);
        Text(description, width);

        CardBottom(width);
    }

    // ==============================
    // MAIN PROGRAM
    // ==============================
    static void Main()
    {
        Console.Title = "Zodiac ID Card Viewer";

        Console.WriteLine("================================");
        Console.WriteLine("     ZODIAC SIGN VIEWER GAME     ");
        Console.WriteLine("================================\n");

        Console.Write("Enter your zodiac sign: ");
        string zodiac = (Console.ReadLine() ?? "").Trim().ToLower();

        Loading("Generating Zodiac Card");

        switch (zodiac)
        {
            case "aries":
                ShowCard(
                    "ARIES",
                    "FIRE",
                    "Energetic, bold, and courageous. Natural leaders full of drive.",
                    new string[]
                    {
                        "      ██████      ",
                        "   ███████████    ",
                        " ███       ███    ",
                        " ██         ██    ",
                        "  ████   ████     ",
                        "    ███████       "
                    });
                break;

            case "taurus":
                ShowCard(
                    "TAURUS",
                    "EARTH",
                    "Reliable and patient. Taurus values stability and comfort.",
                    new string[]
                    {
                        "  ██████    ██████  ",
                        " █████████████████ ",
                        "   █████████████   ",
                        "       █████       ",
                        "   █████████████   ",
                        " █████████████████ "
                    });
                break;

            case "gemini":
                ShowCard(
                    "GEMINI",
                    "AIR",
                    "Curious, expressive, and adaptable. Loves ideas and communication.",
                    new string[]
                    {
                        " ████      ████ ",
                        " ████      ████ ",
                        " ██████████████ ",
                        " ████      ████ ",
                        " ████      ████ "
                    });
                break;

            case "cancer":
                ShowCard(
                    "CANCER",
                    "WATER",
                    "Emotional, caring, and protective. Deeply connected to home.",
                    new string[]
                    {
                        "   ███████████   ",
                        " █████       ██  ",
                        " ███           ",
                        " ███           ",
                        " █████       ██ ",
                        "   ███████████  "
                    });
                break;

            case "leo":
                ShowCard(
                    "LEO",
                    "FIRE",
                    "Confident and charismatic. Loves attention and creativity.",
                    new string[]
                    {
                        "    ████████    ",
                        "  ████      ██  ",
                        " ██            ",
                        " ██            ",
                        "  ████      ██ ",
                        "    ████████   "
                    });
                break;

            case "virgo":
                ShowCard(
                    "VIRGO",
                    "EARTH",
                    "Practical, analytical, and detail-oriented perfectionist.",
                    new string[]
                    {
                        " ██  ██  ██ ",
                        " ██  ██  ██ ",
                        " ██  ██  ██ ",
                        " ██  ██  ██ ",
                        "   ███████  "
                    });
                break;

            case "libra":
                ShowCard(
                    "LIBRA",
                    "AIR",
                    "Balanced, fair, and charming. Seeks harmony and beauty.",
                    new string[]
                    {
                        "   ███████   ",
                        " ███     ███ ",
                        " ███     ███ ",
                        " ███████████",
                        " ███████████"
                    });
                break;

            case "scorpio":
                ShowCard(
                    "SCORPIO",
                    "WATER",
                    "Intense and mysterious. Deep emotions and strong will.",
                    new string[]
                    {
                        " ██ ██ ██ ",
                        " ██ ██ ██ ",
                        " ██ ██ ██ ",
                        " ██ ██ ██ ",
                        " ██ ██ ███"
                    });
                break;

            case "sagittarius":
                ShowCard(
                    "SAGITTARIUS",
                    "FIRE",
                    "Optimistic explorer. Loves freedom and adventure.",
                    new string[]
                    {
                        "     ██████ ",
                        "       ████ ",
                        " ████    ██ ",
                        "   ███████  ",
                        "     ████   "
                    });
                break;

            case "capricorn":
                ShowCard(
                    "CAPRICORN",
                    "EARTH",
                    "Ambitious and disciplined. Focused on long-term success.",
                    new string[]
                    {
                        " ████████ ",
                        " ██    ██ ",
                        " ██    ██ ",
                        " ██    ██ ",
                        " ████████ "
                    });
                break;

            case "aquarius":
                ShowCard(
                    "AQUARIUS",
                    "AIR",
                    "Innovative thinker. Independent and humanitarian.",
                    new string[]
                    {
                        " ██  ██  ",
                        " ███████ ",
                        " ██  ██  ",
                        " ███████ ",
                        " ██  ██  "
                    });
                break;

            case "pisces":
                ShowCard(
                    "PISCES",
                    "WATER",
                    "Dreamy and compassionate. Strong intuition and empathy.",
                    new string[]
                    {
                        " ███   ███ ",
                        "  ███ ███  ",
                        "   █████   ",
                        "  ███ ███  ",
                        " ███   ███ "
                    });
                break;

            default:
                Console.WriteLine("Unknown zodiac sign.");
                break;
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

