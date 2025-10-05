class User
{
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string AvatarUrl { get; set; }
    public string EmojiStatus { get; set; }
    public string TextStatus { get; set; }
    public int Role { get; set; }
    public string BanMessage { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime BannedAt { get; set; }
}
