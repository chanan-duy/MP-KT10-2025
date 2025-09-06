namespace MP_KT10_2025;

public struct ComplexNumber : IComparable<ComplexNumber>
{
    public double Real { get; }
    public double Imaginary { get; }

    public double Magnitude => Math.Sqrt(Real * Real + Imaginary * Imaginary);

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public int CompareTo(ComplexNumber other)
    {
        return Magnitude.CompareTo(other.Magnitude);
    }
}
