namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("foreach nesting");

            int number = 0;
            var domains = new Dictionary<string, string>()
            {
                {"est ","estonia"},
                {"lat ","latvia"},
                {"fin ", "finland"},
                {"swe ", "sweeden"},

            };
            foreach (var domain in domains)
            {
                foreach (var item in domains) ;
            }

        }
    }
} 
