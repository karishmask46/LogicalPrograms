namespace Logical_Programs
{
    class logicalProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for Perfect Number:");
            Console.WriteLine("1 for a perfect number");
            int hammer = Convert.ToInt32(Console.ReadLine());
            switch (hammer)
            {
                case 1:
                    Perfect_Number logic = new Perfect_Number();
                    logic.Perfectnum();
                    break;

            }
           
           
        }
    }

}

