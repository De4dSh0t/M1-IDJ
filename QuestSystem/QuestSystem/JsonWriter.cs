using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace QuestSystem
{
    public class JsonWriter
    {
        /// <summary>
        /// Responsible for serialization
        /// </summary>
        public void Write()
        {
            List<Quest> quests = new List<Quest>()
            {
                new QuestKill()
                {
                    Name = "Defeat the slimes",
                    Description = "Try to kill 3 slimes",
                    IsMain = true,
                    QuestStatus = Status.INACTIVE,
                    Requirements = new List<string>() {"Level 1", "Warrior"},
                    Entities = new List<IKillable>() {new Slime(), new Slime(), new Slime()}
                },

                new QuestCollect()
                {
                    Name = "Collect killed slimes",
                    Description = "Collect 3 killed slimes",
                    IsMain = true,
                    QuestStatus = Status.INACTIVE,
                    Requirements = new List<string>() {"Level 5", "Mage"},
                    Items = new List<ICollectable>() {new Slime(), new Slime(), new Slime()}
                },

                new QuestEscort()
                {
                    Name = "Escort princess slime",
                    Description = "Escort the princess slime to her castle",
                    IsMain = false,
                    QuestStatus = Status.COMPLETED,
                    Requirements = new List<string>() {"Any Level", "Any Class"},
                    Entities = new List<IProtectable>() {new Slime()}
                }
            };
            
            JsonSerializerSettings settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All};
            settings.Formatting = Formatting.Indented;
            string json = JsonConvert.SerializeObject(quests, settings);
            
            File.WriteAllText("quests.json", json);
        }
    }
}