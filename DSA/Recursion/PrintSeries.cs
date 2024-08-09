 class PrintSeries
 {
    public int printInReverse(int n)
    {
        if(n==0)
            return 1;

        else
        {
            Console.WriteLine(n);
            return printInReverse(n-1);
        }
    }

    public void printInOrder(int n)
    {
        if(n>1)
                  
            printInOrder(n-1);
            Console.WriteLine(n);
        }
    }
 