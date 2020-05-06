using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestCollect : Quest
    {
        /// <summary>
        /// List of all the items intended to be collected
        /// </summary>
        public List<ICollectable> Items { get; set; }
        
        public QuestCollect(string name, string description, QuestTypes type, List<ICollectable> items) : base(name, description, type)
        {
            Items = items;
        }

        /// <summary>
        /// Calculates quest progress in percentage
        /// </summary>
        /// <returns></returns>
        public float Progress()
        {
            int count = 0;

            foreach (var item in Items)
            {
                if (item.HasBeenCollected)
                {
                    count++;
                }
            }
            
            return (100 / Items.Count) * count;
        }
        
        /// <summary>
        /// Method used to verify and update the status of the quest
        /// </summary>
        public bool IsCompleted()
        {
            if (Progress() >= 100)
            {
                QuestStatus = Status.DONE;
                return true;
            }

            return false;
        }
    }
}