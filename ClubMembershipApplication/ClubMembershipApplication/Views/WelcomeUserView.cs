using ClubMembershipApplication.FieldValidators;
using ClubMembershipApplication.Models;

namespace ClubMembershipApplication.Views
{
    public class WelcomeUserView : IView
    {
        User _user = null;

        public WelcomeUserView(User user)
        {
            _user = user;
        }

        public IFieldValidator FieldValidator => throw new NotImplementedException();

        public void RunView()
        {
            Console.Clear();
            CommonOutputText.WriteMainHeading();
            CommonOutputFormat.ChangeFontColor(FontTheme.Success);
            Console.WriteLine($"Hi {_user.FirstName}! {Environment.NewLine}Welcome to the Cycling Club!");
            CommonOutputFormat.ChangeFontColor(FontTheme.Default);

            Console.ReadKey();

        }
    }
}