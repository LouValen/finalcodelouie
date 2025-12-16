using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Run(); // call your menu logic
    }

    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========== MAIN MENU ==========");
            Console.WriteLine("1. Music Personality Test");
            Console.WriteLine("2. Zodiac Sign Finder");
            Console.WriteLine("3. MBTI Personality Test");
            Console.WriteLine("4. Exit");
            Console.WriteLine("================================");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(choice))
                continue;

            switch (choice)
            {
                case "1":
                    Music.Run();
                    break;

                case "2":
                    ZodiacIDCard.Run();
                    break;

                case "3":
                    MBTI.Run();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
