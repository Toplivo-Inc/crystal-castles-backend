using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class UserRepository
{
    private CastlesDbContext _dbContext;
    public UserRepository(CastlesDbContext dbContext)
    {
        _dbContext = dbContext;

    }
    public async Task<List<User>> Get()
    {
        var userEntities = await _dbContext.Users
          .AsNoTracking()
          .ToListAsync();

        return userEntities;

    }
    public async Task<Guid> Create(User user)
    {
        var userEntity = new User
        {
            UserId = user.UserId,
            Username = user.Username,
            Email = user.Email,
            Password = user.Password,
            AvatarUrl = user.AvatarUrl,
            EmojiStatus = user.EmojiStatus,
            TextStatus = user.TextStatus,
            Role = user.Role,
            BanMessage = user.BanMessage,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt,
            BannedAt = user.BannedAt
        };
        await _dbContext.AddAsync(userEntity);
        await _dbContext.SaveChangesAsync();

        return userEntity.UserId;
    }
    public async Task<Guid> Delete(Guid userId)
    {
        await _dbContext.Users.Where(b =>b.UserId == userId)
          .ExecuteDeleteAsync(); 
        
        return userId;
    }

    public async Task<Guid> Update(Guid userId, string username, string email, string avatarUrl,
        string textStatus, string emojiStatus, RoleEnum role, string banMessage,
        DateTime createdAt, DateTime updatedAt, DateTime bannedAt)
    {
        await _dbContext.Users
          .Where(b => b.UserId == userId)
          .ExecuteUpdateAsync(s => s
              .SetProperty(u => u.Username, u => username)
              .SetProperty(u => u.Email, u => email)
              .SetProperty(u => u.AvatarUrl, u => avatarUrl)
              .SetProperty(u => u.TextStatus, u => textStatus)
              .SetProperty(u => u.EmojiStatus, u => emojiStatus)
              .SetProperty(u => u.Role, u => role)
              .SetProperty(u => u.BanMessage, u => banMessage)
              .SetProperty(u => u.CreatedAt, u => createdAt)
              .SetProperty(u => u.UpdatedAt, u => updatedAt)
              .SetProperty(u => u.BannedAt, u => bannedAt));

        return userId;
    }

}
