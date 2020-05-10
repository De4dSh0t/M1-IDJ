using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestDefend : Quest
    {
        public List<IProtectable> Entities { get; set; }
        
        public QuestDefend()
        {
            Name = "";
            Description = "";
        }
        
        public QuestDefend(string name, string description, List<IProtectable> entities) : base(name, description)
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
                if (entity.HasSurvived)
                {
                    count++;
                }
            }
            
            //In case the quest is already completed, return 100%
            if (QuestStatus == Status.COMPLETED)
            {
                return 100;
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