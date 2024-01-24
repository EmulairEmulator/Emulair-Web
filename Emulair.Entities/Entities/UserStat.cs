namespace EmulairWEB.Models
{
    public partial class UserStat
    {
        public Guid StatId { get; set; }
        public Guid UserId { get; set; }
        public decimal? ValueN { get; set; }
        public string? ValueC { get; set; }
        public bool? ValueB { get; set; }

        public virtual Stat Stat { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
