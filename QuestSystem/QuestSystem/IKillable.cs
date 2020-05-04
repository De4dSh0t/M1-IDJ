namespace QuestSystem
{
    public interface IKillable
    {
        public int Heatlh { get; set; }
        
        public bool IsDead();
    }
}