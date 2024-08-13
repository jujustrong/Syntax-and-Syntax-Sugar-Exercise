namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            LessThanNine();
        }

        public static void LessThanNine()
        {
            Random n = new Random();
            var answer = n.Next(1, 100);
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}
