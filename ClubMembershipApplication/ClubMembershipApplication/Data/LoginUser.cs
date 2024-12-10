
using ClubMembershipApplication.Models;

namespace ClubMembershipApplication.Data
{
    public class LoginUser : ILogin
    {
        public User Login(string emailAddress, string password)
        {
            User user = null;

            using var dbContext = new ClubMembershipDbContext();

            user = dbContext.Users.FirstOrDefault(u => u.EmailAddress.Trim().ToLower() == emailAddress.ToLower() && u.Password.Equals(password));

            return user;



        }
    }
}