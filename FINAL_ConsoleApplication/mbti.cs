using System;

public static class MBTI
{
    public static void Run()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Abc.hatdog();

        string[] inputs = {
            "\t\tIntrovert [I] or Extrovert [E]",
            "\t\tSensors [S] or Intuitives [N]",
            "\t\tFeelers [F] or Thinkers [T]",
            "\t\tPerceivers [P] or Judgers [J]"
        };

        Console.WriteLine("\nChoose Letter:\n");
        foreach (string input in inputs) Console.WriteLine(input);

        string result = "";
        for (int i = 1; i <= 4; i++)
            result += Console.ReadLine()?.ToUpper() ?? "";

        Console.WriteLine($"\nYour MBTI Type: {result}\n");

        switch (result)
        {
            case "ISTJ":
                Console.WriteLine("The Responsible Archivist — practical, orderly, duty-driven. ");
                break;
            case "ISFJ":
                Console.WriteLine("The Quiet Caretaker — warm, dependable, detail-focused. ");
                break;
            case "INFJ":
                Console.WriteLine("The Insightful Idealist — visionary, empathetic, mysterious");
                break;
            case "INTJ":
                Console.WriteLine("The Strategic Architect — independent, analytical, future-minded");
                break;
            case "ISTP":
                Console.WriteLine("The Resourceful Tinkerer — hands-on, adaptable, cool-under-fire");
                break;
            case "ISFP":
                Console.WriteLine("The Creative Realist — aesthetic, gentle, lives in the moment");
                break;
            case "INFP":
                Console.WriteLine("The Dreamy Healer — values-driven, imaginative, quietly passionate");
                break;
            case "INTP":
                Console.WriteLine("The Curious Theorist — abstract, clever, loves puzzles");
                break;
            case "ESTP":
                Console.WriteLine("The Energetic Doer — bold, action-first, street-smart");
                break;
            case "ESFP":
                Console.WriteLine("The Playful Performer — spontaneous, sociable, life-of-the-party");
                break;
            case "ENFP":
                Console.WriteLine("The Enthusiastic Spark — inventive, optimistic, people-centered");
                break;
            case "ENTP":
                Console.WriteLine("The Quick-Witted Debater — clever, innovative, idea-hungry");
                break;
            case "ESTJ":
                Console.WriteLine("The Organized Captain — decisive, practical, takes charge");
                break;
            case "ESFJ":
                Console.WriteLine("The Sociable Nurturer — warm, responsible, community-minded");
                break;
            case "ENFJ":
                Console.WriteLine("The Charismatic Mentor — inspiring, empathetic, natural leader");
                break;
            case "ENTJ":
                Console.WriteLine("The Commanding Visionary — strategic, confident, goal-driven");
                break;
            default: 
                Console.WriteLine("Unknown MBTI Type."); 
                break;
        }

        Console.WriteLine("\nPress any key to return...");
        Console.ReadLine();
    }
}
