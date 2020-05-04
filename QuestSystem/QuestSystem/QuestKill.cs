using System;
using System.Collections.Generic;

namespace QuestSystem
{
    public class QuestKill : Quest
    {
        public List<IKillable> Entities { get; set; }
        
        public QuestKill(string name, string description, QuestTypes type, List<IKillable> entities) : base(name, description, type)
        {
            Entities = entities;
        }

        /// <summary>
        /// Returns a bool (False -> "Not Dead" | True -> "Dead")
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i].Heatlh <= 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Calculates quest progress in percentage
        /// </summary>
        /// <returns></returns>
        public float Progress()
        {
            int count = 0;
            
            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i].IsDead())
                {
                    count++;
                }
            }

            return (100 / Entities.Count) * count;
        }
    }
}