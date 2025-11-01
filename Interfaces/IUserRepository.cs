
using CrystalCastlesBackend.Models;

namespace CrystalCastlesBackend.Interfaces
{
  public interface IUserRepository
  {
    Task<Guid> Create(User user);
    Task<Guid> Delete(Guid userId);
    Task<List<User>> Get();
    Task<Guid> Update(Guid userId, string username, string email, string avatarUrl, string textStatus, string emojiStatus, RoleEnum role, string banMessage, DateTime createdAt, DateTime updatedAt, DateTime bannedAt);
  }
}
