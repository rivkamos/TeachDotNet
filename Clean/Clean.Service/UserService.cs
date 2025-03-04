using Clean.Core.Entities;
using Clean.Core.Repositories;
using Clean.Core.Services;
using Microsoft.Extensions.Configuration;

namespace Clean.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll();
        }
    }



    public class MyService
    {
        private readonly IConfiguration _configuration;

        public MyService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void DoSomething()
        {
            var connectionString = _configuration["DefaultConnection"];
            var title = _configuration["Logging:LogLevel"];
        }
    }
}

