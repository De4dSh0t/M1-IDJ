namespace QuestSystem
{
    /// <summary>
    /// Class used to test the system
    /// </summary>
    public class Slime : IKillable, ICollectable, IProtectable
    {
        public bool IsDead { get; set; }
        public bool HasBeenCollected { get; set; }
        public bool HasArrived { get; set; }
    }
}