using System;

namespace QuestSystem
{
    public class SideQuest : Quest
    {
        public SideQuest(string name, string description, TimeSpan duration) : base(name, description, duration) {}
    }
}