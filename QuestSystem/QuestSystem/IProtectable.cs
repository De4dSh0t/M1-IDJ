namespace QuestSystem
{
    /// <summary>
    /// Interface used to provide compatibility with class "QuestProtect"
    /// </summary>
    public interface IProtectable
    {
        public bool HasArrived { get; set; }
    }
}