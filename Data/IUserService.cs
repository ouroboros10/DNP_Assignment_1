using DNP_Assignment_1.Models;

namespace DNP_Assignment_1.Data
{
    public interface IUserService
    {
        User ValidateUser(string Username, string Password);
    }
}