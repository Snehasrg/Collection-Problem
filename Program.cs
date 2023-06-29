// See https://aka.ms/new-console-template for more information
using CollectionPracticeProblem;
namespace CollectionPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select any one option from following:-\n" +
                                "1. Count Of Remaining Chapters.\n2. Max Selling Price.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Chapter chaptersCount = new Chapter();
                    chaptersCount.RemainingChapters();
                    break;
                case 2:
                    MaxSellPrice maxSellPrice = new MaxSellPrice();
                    maxSellPrice.MaxSell();
                    break;

                default:
                    break;
            }
        }
    }
}
