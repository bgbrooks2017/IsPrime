public class Program
{
    public static bool isPrime(int x)
    {
        if (x <= 1)
        {
            return false;
        }
        for (int i = 2; i < n; i++)
        {
            if ((n % i) == 0)
            {
                return false;
            }
        }
        return true;
    }
}