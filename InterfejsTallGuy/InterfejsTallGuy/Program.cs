using InterfejsTallGuy;

public class TallGuy : IClown
{
    public string Name;
    public int Height;

    public void TalkAboutYourself()
    {
        Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu.");
    }
    static void Main(string[] args)
    {
        TallGuy tallguy = new TallGuy() { Height = 74, Name = "Adam"};
        tallguy.TalkAboutYourself();

        
        tallguy.Honk();
    }
}