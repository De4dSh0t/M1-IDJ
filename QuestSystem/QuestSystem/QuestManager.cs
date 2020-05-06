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
        
        public void ReadJson(string file)
        {
            string content = File.ReadAllText(file);
            
            JsonSerializerSettings settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All};
            quest = JsonConvert.DeserializeObject<List<Quest>>(content, settings);
        }
    }
}