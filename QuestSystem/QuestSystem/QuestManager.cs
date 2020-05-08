using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace QuestSystem
{
    public class QuestManager
    {
        public List<Quest> quest = new List<Quest>();
        
        /// <summary>
        /// Converts the json file to quest objects
        /// </summary>
        /// <param name="file"></param>
        public void ReadJson(string file)
        {
            string content = File.ReadAllText(file);
            
            JsonSerializerSettings settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            quest = JsonConvert.DeserializeObject<List<Quest>>(content, settings);
        }

        /// <summary>
        /// Creates a list of active quests
        /// </summary>
        /// <returns></returns>
        public List<Quest> ActiveQuests()
        {
            List<Quest> active = new List<Quest>();

            foreach (var q in quest)
            {
                if (q.QuestStatus == Status.ACTIVE)
                {
                    active.Add(q);
                }
            }

            return active;
        }

        /// <summary>
        /// Creates a list of inactive quests
        /// </summary>
        /// <returns></returns>
        public List<Quest> InactiveQuests()
        {
            List<Quest> inactive = new List<Quest>();

            foreach (var q in quest)
            {
                if (q.QuestStatus == Status.INACTIVE)
                {
                    inactive.Add(q);
                }
            }

            return inactive;
        }

        /// <summary>
        /// Creates a list of cancelled quests
        /// </summary>
        /// <returns></returns>
        public List<Quest> CancelledQuests()
        {
            List<Quest> cancelled = new List<Quest>();

            foreach (var q in quest)
            {
                if (q.QuestStatus == Status.CANCELLED)
                {
                    cancelled.Add(q);
                }
            }

            return cancelled;
        }

        /// <summary>
        /// Creates a list of completed quests
        /// </summary>
        /// <returns></returns>
        public List<Quest> CompletedQuests()
        {
            List<Quest> completed = new List<Quest>();

            foreach (var q in quest)
            {
                if (q.QuestStatus == Status.DONE)
                {
                    completed.Add(q);
                }
            }

            return completed;
        }

        /// <summary>
        /// Creates a list of main quests
        /// </summary>
        /// <returns></returns>
        public List<Quest> MainQuests()
        {
            List<Quest> main = new List<Quest>();

            foreach (var q in quest)
            {
                if (q.IsMain)
                {
                    main.Add(q);
                }
            }

            return main;
        }
        
        /// <summary>
        /// Creates a list of side quests
        /// </summary>
        /// <returns></returns>
        public List<Quest> SideQuests()
        {
            List<Quest> side = new List<Quest>();

            foreach (var q in quest)
            {
                if (q.IsMain == false)
                {
                    side.Add(q);
                }
            }

            return side;
        }

        /// <summary>
        /// Calculates the progress of all main quests
        /// </summary>
        /// <returns></returns>
        public double MainProgress()
        {
            int count = 0;

            foreach (var q in MainQuests())
            {
                if (q.QuestStatus == Status.DONE)
                {
                    count++;
                }
            }
            
            return (double) 100 / MainQuests().Count * count;
        }
        
        /// <summary>
        /// Calculates the progress of all side quests
        /// </summary>
        /// <returns></returns>
        public double SideProgress()
        {
            int count = 0;

            foreach (var q in SideQuests())
            {
                if (q.QuestStatus == Status.DONE)
                {
                    count++;
                }
            }
            
            return (double) 100 / SideQuests().Count * count;
        }
        
        /// <summary>
        /// Calculates the total progress of all quests
        /// </summary>
        /// <returns></returns>
        public double TotalProgress()
        {
            int count = 0;

            foreach (var q in quest)
            {
                if (q.QuestStatus == Status.DONE)
                {
                    count++;
                }
            }
            
            return (double) 100 / quest.Count * count;
        }
    }
}