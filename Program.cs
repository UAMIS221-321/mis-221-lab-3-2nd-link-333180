using System;

class CollegeFootballIntro
{
    static void Main()
    {
        string enjoymentLevel = GetEnjoymentLevel();
        string stadium = GetStadiumRecommendation(enjoymentLevel);
        string game = GetGameRecommendation(stadium);
        Console.WriteLine(DisplayStadiumDetails(stadium, game));
    }

    static string GetEnjoymentLevel()
    {
        
        Console.WriteLine("Enter your preferred level of enjoyment (Boring, Average, Fun, Epic):");
        string input = Console.ReadLine().ToLower();
        while (input != "boring" && input != "average" && input != "fun" && input != "epic")
        {
            Console.WriteLine("Invalid input. Please enter Boring, Average, Fun, or Epic:");
            input = Console.ReadLine().ToLower();
        }
        return input;
    }

    static string GetStadiumRecommendation(string enjoymentLevel)
    {
        switch (enjoymentLevel)
        {
            case "boring":
                return "Neyland Stadium";
            case "average":
                return "Jordan-Hare Stadium";
            case "fun":
                return "Tiger Stadium";
            case "epic":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                return "Unknown Stadium";
        }
    }

    static string GetGameRecommendation(string stadium)
    {
        switch (stadium)
        {
            case "Neyland Stadium":
                return "Kent State";
            case "Jordan-Hare Stadium":
                return "Kentucky";
            case "Tiger Stadium":
                return "Alabama";
            case "Saban Field at Bryant-Denny Stadium":
                return "Auburn";
            default:
                return "Unknown Game";
        }
    }

    static string DisplayStadiumDetails(string stadium, string game)
    {
        return $"Based on your preference, we recommend attending the game at {stadium}. The best game to watch there is against {game}.";
    }
}