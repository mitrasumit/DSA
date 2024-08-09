public class SumOfn
{
    public int calculate(int n)
    {
        if(n==1)
        {
            return 1;
        }
        else 
        {
            return calculate(n-1)+n;
        }
    }
}