namespace Giraffe
{
    class Program
    {
        static void Main(String[] args)
        {
            String str = "Dog";
            Console.Write("Enter a number : ");
           int  x=Convert.ToInt32( Console.ReadLine());

            Console.Write("Enter another number : ");
            int y = Convert.ToInt32(Console.ReadLine());
                ;
            Console.WriteLine("the sum of the numbers is "+add(x,y));
            Console.ReadLine();
           
        }
        static int add(int x,int y)
        {
            return x+y;
            
        }
    }
}