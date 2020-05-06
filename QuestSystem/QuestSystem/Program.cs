using System;
using System.Collections.Generic;

namespace QuestSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonWriter jsonWriter = new JsonWriter();
            jsonWriter.Write();
            QuestManager questManager = new QuestManager();
            questManager.ReadJson("quests.json");
        }
    }
}