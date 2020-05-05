using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestProtect : Quest
    {
        /// <summary>
        /// List of all the entities intended to be protected
        /// </summary>
        public List<IProtectable> Entities { get; set; }
        
        public QuestProtect(string name, string description, QuestTypes type, List<IProtectable> entities) : base(name, description, type)
        {
            Entities = entities;
        }

        public float Progress()
        {
            int count = 0;

            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i].HasArrived)
                {
                    count++;
                }
            }
            
            return (100 / Entities.Count) * count;
        }
    }
}