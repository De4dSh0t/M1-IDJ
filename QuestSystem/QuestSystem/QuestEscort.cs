using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestEscort : Quest
    {
        /// <summary>
        /// "Type" property override (Helpfull in deserialization)
        /// </summary>
        public override string Type
        {
            get => "QuestEscort";
        }
        
        /// <summary>
        /// List of all the entities intended to be escorted/protected
        /// </summary>
        public List<IProtectable> Entities { get; set; }
        
        public QuestEscort(string name, string description, string type, List<IProtectable> entities) : base(name, description, type)
        {
            Entities = entities;
        }

        /// <summary>
        /// Calculates quest progress in percentage
        /// </summary>
        /// <returns></returns>
        public float Progress()
        {
            int count = 0;

            foreach (var entity in Entities)
            {
                if (entity.HasArrived)
                {
                    count++;
                }
            }
            
            return (100 / Entities.Count) * count;
        }
        
        /// <summary>
        /// Method used to verify the progress and update the status of the quest
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