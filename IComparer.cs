namespace MP_KT10_2025;

public interface IComparer<in T> where T : struct
{
    public int Compare(T x, T y);
}
