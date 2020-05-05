namespace QuestSystem
{
    /// <summary>
    /// Interface used to provide compatibility with class "QuestCollect"
    /// </summary>
    public interface ICollectable
    {
        public bool HasBeenCollected { get; set; }
    }
}