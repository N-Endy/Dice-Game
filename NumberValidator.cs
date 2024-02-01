public class NumberValidator
{
    readonly int rolledDie = DieRoller.Roll();

    public bool IsNumber(string numberInStringFormat)
    {
        return int.TryParse(numberInStringFormat, out int result);
    }

    public bool Validate(int number)
    {
        return number == rolledDie;
    }
}