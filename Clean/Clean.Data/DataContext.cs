using Clean.Core.Entities;
using Clean.Core.Repositories;

namespace Clean.Data
{
    public class DataContext : IDataContext
    {
        public List<User> Users { get; set; }

        public DataContext()
        {
                Users = new List<User>() { 
                new User() { Id = 1, Email="user@dd.com", Name ="user", Password="1234"}
                };
        }
    }
}
