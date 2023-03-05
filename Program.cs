namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        //declaração do objeto (declarete a new object)
        Random random = new Random();

        int number = random.Next(1,30);

         if(number == 30)
            {
                Console.WriteLine("Goal!!!\n");
                Console.WriteLine("You take the luck number: " + number);
            }
         else
            {
                Console.WriteLine("You lost!!! Try again\n" + "Your nabember is:" + number);
            }
        }
    }
}
