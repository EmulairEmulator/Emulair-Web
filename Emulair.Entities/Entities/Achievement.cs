namespace EmulairWEB.Models
{
    public partial class Achievement
    {
        public Achievement()
        {
            UserAchievements = new HashSet<UserAchievement>();
        }

        public Guid AchievementId { get; set; }
        public Guid? GameId { get; set; }
        public Guid? IconPendingId { get; set; }
        public Guid? IconCompletedId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual Game? Game { get; set; }
        public virtual Image? IconCompleted { get; set; }
        public virtual Image? IconPending { get; set; }
        public virtual ICollection<UserAchievement> UserAchievements { get; set; }
    }
}
