public class DieRoller
{
    private const int diceSidesCount = 6;
    public static int Roll()
    {
        var random = new Random();
        return random.Next(1, diceSidesCount + 1);
    }
}