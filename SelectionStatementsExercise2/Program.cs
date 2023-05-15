namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?(please capitalize first letter)");
            string mySubject = Console.ReadLine();


            switch (mySubject)
            {
                case "Geometry":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "Calculus":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "Statistics":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "History":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                case "Biology":
                    Console.WriteLine($"{mySubject} is my favorite subject too!");
                    break;
                default:
                    Console.WriteLine("We must have missed that one.");
                    break;
            }
            }
    }
}