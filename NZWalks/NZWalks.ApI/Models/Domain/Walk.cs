namespace NZWalks.ApI.Models.Domain
{
    public class Walk
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //Navigation Property
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
