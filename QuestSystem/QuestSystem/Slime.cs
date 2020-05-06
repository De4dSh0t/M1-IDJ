namespace QuestSystem
{
    public class Slime : IKillable, ICollectable, IProtectable
    {
        public bool IsDead { get; set; }
        public bool HasBeenCollected { get; set; }
        public bool HasArrived { get; set; }
    }
}