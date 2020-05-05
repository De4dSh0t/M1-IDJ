namespace QuestSystem
{
    /// <summary>
    /// Interface used to provide compatibility with class "QuestKill" and "QuestProtect"
    /// </summary>
    public interface IKillable
    {
        public bool IsDead { get; set; }
    }
}