using Shopp.Data.Models;

namespace Shopp.Data.Interfaces
{
    public interface IAllUsers
    {

        bool createUser(User user);
        public User getUser(User u);

    }
}
