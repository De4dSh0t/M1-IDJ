using System;

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
            Type type = questManager.quest[0].GetType();

            var questKill = (QuestKill) questManager.quest[0];
            questKill.Entities[0].IsDead = true;
            questKill.Entities[1].IsDead = true;
            questKill.Entities[2].IsDead = true;
            Console.WriteLine(questKill.Progress());
            Console.WriteLine(questKill.IsCompleted());
            Console.WriteLine(questManager.InactiveQuests().Count);
            Console.WriteLine(questManager.CompletedQuests().Count);
        }
    }
}