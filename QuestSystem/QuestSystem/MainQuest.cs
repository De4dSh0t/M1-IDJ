using System;

namespace QuestSystem
{
    public class MainQuest : Quest
    {
        public MainQuest(string name, string description, TimeSpan duration) : base(name, description, duration) {}
    }
}