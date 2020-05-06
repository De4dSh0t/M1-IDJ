using System;
using Newtonsoft.Json.Linq;

namespace QuestSystem
{
    public class QuestSerializer : JsonSerializer<Quest>
    {
        protected override Quest Create(Type objectType, JObject jsonObject)
        {
            string typeName = jsonObject["type"].ToString();

            switch (typeName)
            {
                case "QuestKill":
                {
                    return new QuestKill();
                }
                case "QuestCollect":
                {
                    return new QuestCollect();
                }
                case "QuestEscort":
                {
                    return new QuestEscort();
                }
                default:
                {
                    return null;
                }
            }
        }
    }
}