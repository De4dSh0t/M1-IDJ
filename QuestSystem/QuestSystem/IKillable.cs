namespace QuestSystem
{
    public interface IKillable
    {
        public int Heatlh { get; set; }

        public void Hit();
        public bool IsDead();
    }
}