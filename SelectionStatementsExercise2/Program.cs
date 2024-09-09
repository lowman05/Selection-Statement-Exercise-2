namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            var mySubject = Console.ReadLine();


            switch (mySubject.ToLower())
            {
                case "geometry":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "calculus":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "statistics":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "history":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "biology":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                default:
                    Console.WriteLine("We must have missed that one.");
                    break;
            }

        }
    }
}