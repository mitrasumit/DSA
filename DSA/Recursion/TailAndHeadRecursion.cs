public class TailAndHeadRecursion
{
    //Tail-Recursion
    public void calculateTail(int n)
    {
        if(n>0)
        {
            int k=n*n;
            Console.WriteLine(k);
            calculateTail(n-1);
        }
    }

    public void calculateHead(int n)
    {
        if(n>0)
        {
            calculateHead(n-1);
            int k=n*n;
            Console.WriteLine(k);
        }
    }
}