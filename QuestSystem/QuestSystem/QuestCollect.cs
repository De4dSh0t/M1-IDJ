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
        public float Progression()
        {
            int count = 0;

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].HasBeenCollected)
                {
                    count++;
                }
            }
            
            return (100 / Items.Count) * count;
        }
    }
}