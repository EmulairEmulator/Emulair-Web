namespace Emulair.BusinessLogic.Implementation.Game.Models
{
    public class GameListItem
    {
        public Guid GameId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? TotalHoursPlayed { get; set; }
        public DateTime? LastPlayed { get; set; }
        public int? TotalAchievements { get; set; }
        public int? TotalAchievementsUnlocked { get; set; }
    }
}
