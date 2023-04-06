// See https://aka.ms/new-console-template for more information
using CollectionPracticeProblem;
namespace CollectionPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select any one option from following:-\n" +
                                "1. Count Of Remaining Chapters");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Chapter chaptersCount = new Chapter();
                    chaptersCount.RemainingChapters();
                    break;

                default:
                    break;
            }
        }
    }
}
