namespace Exercise1
{
    class program
    {
        static void Main(String[] args)
        {
            Console.Write("Please Enter a Value: ");
            int num = Convert.ToInt32(Console.ReadLine()) ;
            if(num % 3 == 0 & num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
                Console.WriteLine(num);


        }
    }
}
