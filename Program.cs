namespace LeetCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string selectedCategory = "01-Basic-Logic";

            switch (selectedCategory)
            {
                case "01-Basic-Logic":
                    BasicLogicRunner.Run();
                    break;

                default:
                    Console.WriteLine("Category not found.");
                    break;
            }
        }
    }
}
