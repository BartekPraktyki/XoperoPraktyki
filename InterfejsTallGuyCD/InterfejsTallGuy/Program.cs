using InterfejsTallGuy;

public class TallGuy
{
    static void Main(string[] args)
    {
        ScaryScary fingersTheClown = new ScaryScary("duże buty", 35);
        FunnyFunny someFunnyClown = fingersTheClown;
        IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
        someOtherScaryClown.Honk();
        Console.ReadKey();
    }
}