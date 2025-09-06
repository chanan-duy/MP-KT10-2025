namespace MP_KT10_2025;

public struct RationalNumber : IComparable<RationalNumber>
{
    public long Numerator { get; set; }
    public long Denominator { get; set; }

    public RationalNumber(long numerator, long denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public int CompareTo(RationalNumber other)
    {
        var thisNumerator = Numerator * other.Denominator;
        var otherNumerator = other.Numerator * Denominator;

        return thisNumerator.CompareTo(otherNumerator);
    }
}
