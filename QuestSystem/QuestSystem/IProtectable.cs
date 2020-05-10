namespace QuestSystem
{
    /// <summary>
    /// Interface used to provide compatibility with class "QuestEscort" and "QuestDefend"
    /// </summary>
    public interface IProtectable
    {
        public bool HasArrived { get; set; }
        public bool HasSurvived { get; set; }
    }
}