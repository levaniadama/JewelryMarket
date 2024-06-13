using JewelryMarket.Entities;

namespace JewelryMarket.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IReadOnlyList<User>> GetAllUsersAsync();
        Task<User> GetUserByUsernameOrEmailAsync(string usernameOrEmail);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task SaveChangesAsync();
    }
}
