namespace emoloyee_present_or_not
{


    class programm
    {


        static void Main(string[] args)

        {
            int IS_FULL_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}