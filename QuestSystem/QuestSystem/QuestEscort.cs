using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestEscort : Quest
    {
        /// <summary>
        /// List of all the entities intended to be escorted/protected
        /// </summary>
        public List<IProtectable> Entities { get; set; }

        public QuestEscort()
        {
            Name = "";
            Description = "";
        }
        
        public QuestEscort(string name, string description, List<IProtectable> entities) : base(name, description)
        {
            Entities = entities;
        }

        /// <summary>
        /// Calculates quest progress in percentage
        /// </summary>
        /// <returns></returns>
        public double Progress()
        {
            int count = 0;

            foreach (var entity in Entities)
            {
                if (entity.HasArrived)
                {
                    count++;
                }
            }
            
            return (double) 100 / Entities.Count * count;
        }
        
        /// <summary>
        /// Method used to verify the progress and update the status of the quest
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