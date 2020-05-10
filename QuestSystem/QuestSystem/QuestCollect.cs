using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestCollect : Quest
    {
        /// <summary>
        /// List of all the items intended to be collected
        /// </summary>
        public List<ICollectable> Items { get; set; }

        public QuestCollect()
        {
            Name = "";
            Description = "";
        }

        public QuestCollect(string name, string description, List<ICollectable> items) : base(name, description)
        {
            Items = items;
        }

        /// <summary>
        /// Calculates quest progress in percentage
        /// </summary>
        /// <returns></returns>
        public double Progress()
        {
            int count = 0;

            foreach (var item in Items)
            {
                if (item.HasBeenCollected)
                {
                    count++;
                }
            }

            //In case the quest is already completed, return 100%
            if (QuestStatus == Status.COMPLETED)
            {
                return 100;
            }
            
            return (double) 100 / Items.Count * count;
        }
        
        /// <summary>
        /// Method used to verify and update the status of the quest
        /// </summary>
        public bool IsCompleted()
        {
            if (Progress() >= 100)
            {
                QuestStatus = Status.COMPLETED;
                return true;
            }

            return false;
        }
    }
}