namespace MP_KT10_2025;

public class RationalNumberComparer : IComparer<RationalNumber>
{
    public int Compare(RationalNumber x, RationalNumber y)
    {
        return x.CompareTo(y);
    }

    public string CompareToString(RationalNumber x, RationalNumber y)
    {
        return Compare(x, y) switch
        {
            0 => "==",
            < 0 => "<",
            _ => ">",
        };
    }
}
