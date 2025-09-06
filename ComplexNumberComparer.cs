namespace MP_KT10_2025;

public class ComplexNumberComparer : IComparer<ComplexNumber>
{
    public int Compare(ComplexNumber x, ComplexNumber y)
    {
        return x.CompareTo(y);
    }

    public string CompareToString(ComplexNumber x, ComplexNumber y)
    {
        return Compare(x, y) switch
        {
            0 => "==",
            < 0 => "<",
            _ => ">",
        };
    }
}
