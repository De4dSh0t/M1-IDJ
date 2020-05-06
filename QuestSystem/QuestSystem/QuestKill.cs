using System;
using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestKill : Quest
    {
        /// <summary>
        /// List of all the entities intended to be killed
        /// </summary>
        public List<IKillable> Entities { get; set; }
        
        public QuestKill(string name, string description, QuestTypes type, List<IKillable> entities) : base(name, description, type)
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
            
            //Goes through the entire list "Entities", to verify if an entity is dead. If so, count++.
            foreach (var entity in Entities)
            {
                if (entity.IsDead) //If the specified entity is dead, then count++
                {
                    count++;
                }
            }

            return (100 / Entities.Count) * count;
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