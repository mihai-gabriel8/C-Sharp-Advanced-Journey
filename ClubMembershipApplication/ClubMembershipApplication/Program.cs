// See https://aka.ms/new-console-template for more information
using ClubMembershipApplication.Views;


namespace ClubMembershipApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IView mainView = Factory.GetMainViewObject();
            mainView.RunView();

            Console.ReadKey();
        }
    }

}
