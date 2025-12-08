using System;

public class Abc
{
    public static void hatdog()
    {
        string[] left = {
            "                 .--.   _",
            "             .---|__| .((\\=.",
            "          .--|===|--|/    ,(,",
            "          |  |===|  |\\      y",
            "          |%%|   |  | `.__,'",
            "          |%%|   |  | /  \\\\",
            "          |  |   |  |/|  | \\`----.",
            "          |  |   |  ||\\  \\  |___.'_" ,
            "         _|  |   |__||,\\  \\-+-._.' )_",
            "        / |  |===|--|\\  \\  \\      /  \\",
            "       /  `--^---'--' `--`-'---^-'    \\",
            "      '================================`"
        };

        int mid = left.Length / 2;

        for (int i = 0; i < left.Length; i++)
        {
            if (i == mid)
                Console.WriteLine(left[i].PadRight(55) + "Type only [1] letter and press Enter per pick.");
            else
                Console.WriteLine(left[i]);
        }
    }
}
