using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Models;

namespace ClubMembershipApplication.Views
{
    public class MainView : IView
    {
        User _user = null;
        IView _registerView = null;
        IView _loginView = null;

        public MainView(IView registerView, IView loginView)
        {
            _registerView = registerView;
            _loginView = loginView;
        }

        public IFieldValidator FieldValidator => null;

        public void RunView()
        {
            CommonOutputText.WriteMainHeading();
            Console.WriteLine($"Press 'l' to login or if you are not registered yet press 'r'!");

            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.R)
            {
                RunUserRegistrationView();
                RunUserLoginView();

            }
            else if (key == ConsoleKey.L)
            {
                RunUserLoginView();
            }
            else
            {

                Console.Clear();
                Console.WriteLine("GoodBye!");
                Console.ReadKey();
            }

        }

        private void RunUserRegistrationView()
        {
            _registerView.RunView();
        }
        private void RunUserLoginView()
        {
            _loginView.RunView();
        }
    }
}