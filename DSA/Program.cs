
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----------------DSA------------");

        /* TailAndHeadRecursion c = new TailAndHeadRecursion();
        c.calculateTail(6);
        c.calculateHead(6); */

        /* SumOfn obj=new SumOfn();
        Console.WriteLine(obj.calculate(5)); */

       /*  Factorial obj=new Factorial();
        Console.WriteLine(obj.calculate(5)); */

        PrintSeries obj=new PrintSeries();
        obj.printInOrder(5);
        //obj.printInReverse(5);
        }
    }
